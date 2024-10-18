using Menagelec.Entities;
using Menagelec.src.Models;
using System.Data;
using System.Diagnostics;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Runtime.InteropServices;
using System.Drawing;
namespace Menagelec.Forms
{
    public partial class fmOrders : Form
    {
        private List<Order> allOrders = OrderModel.findAllOrders();

        public fmOrders()
        {
            InitializeComponent();

            // DataGridView DataSource selon la liste de commandes
            this.setOrderDataSource(allOrders);
            // Infos sur la commande sélectionnée
            this.getAllSelectedOrderInfo();

        }

        // MaJ du DataSource de la grid commande
        private void setOrderDataSource(List<Order> filteredOrderList)
        {
            // On initialise un DataTable avec la liste de commandes filtrée
            DataTable newOrderDt = createOrderDt(filteredOrderList);
            this.ordersDataGridView.DataSource = newOrderDt;
            // Compteur de commande
            lb_orderCount.Text = $"Nombre d'éléments :   {newOrderDt.Rows.Count}";
            // Sélection de la 1ère commande de la grid
            if (newOrderDt.Rows.Count > 0) { this.ordersDataGridView.CurrentCell = ordersDataGridView.Rows[0].Cells[0]; }
        }

        // Obtenir toutes les informations sur la commande sélectionnée (Client, Commande, Réferences)
        private void getAllSelectedOrderInfo()
        {
            // selected order info
            if (this.ordersDataGridView.CurrentCell == null) return;
            Order selectedOrder = OrderModel.findOrderById(int.Parse(this.ordersDataGridView.CurrentCell.Value.ToString()));
            this.getOrderClientInformations(selectedOrder);
            this.getOrderInformations(selectedOrder);
            // references
            DataTable referencesDt = createOrderRowDtByOrder(selectedOrder);
            this.orderRowsDataGridView.DataSource = referencesDt;
            lb_orderRowsCount.Text = $"Nombre de références dans la commande : {referencesDt.Rows.Count}";
        }

        // Créer DataTable pour les commandes en fonction d'une liste selon le filtre
        private DataTable createOrderDt(List<Order> ordersList)
        {
            DataTable orderDataTable = new DataTable();
            orderDataTable.Columns.Add("idCommande");
            orderDataTable.Columns.Add("date");
            orderDataTable.Columns.Add("client");
            foreach (Order order in ordersList)
            {
                orderDataTable.Rows.Add(order.getId(), order.getDate().ToString("dd/MM/yyyy"), order.getClient().getId());
            }

            return orderDataTable;
        }
        // Créer DataTable pour les références de la commande sélectionnée
        private DataTable createOrderRowDtByOrder(Order order)
        {
            DataTable orderRowsDataTable = new DataTable();
            orderRowsDataTable.Columns.Add("Produit commandé");
            orderRowsDataTable.Columns.Add("Quantité");

            List<OrderRow> selectedOrderReferences = OrderRowModel.findAllByOrder(order);
            foreach (OrderRow reference in selectedOrderReferences)
            {
                orderRowsDataTable.Rows.Add(reference.getProduct().getId(), reference.getQuantity());
            }
            return orderRowsDataTable;
        }

        // Obtenir les informations du client de la commande sélectionnée
        private void getOrderClientInformations(Order selectedOrder)
        {
            groupBox_client.Text = $"client {selectedOrder.getClient().getId()}";
            lb_civility.Text = selectedOrder.getClient().getCivility();
            lb_lastName.Text = selectedOrder.getClient().getLastName();
            lb_name.Text = selectedOrder.getClient().getName();
            lb_address.Text = selectedOrder.getClient().getAddress();
            lb_postalCode.Text = selectedOrder.getClient().getPostalCode();
            lb_city.Text = selectedOrder.getClient().getCity();
            lb_client_email.Text = selectedOrder.getClient().getEmail();
            lb_client_phone.Text = selectedOrder.getClient().getPhone();
        }

        private void getOrderInformations(Order selectedOrder)
        {
            groupBox_order.Text = $"Commande n° {selectedOrder.getId()}";
            lb_order_date.Text = selectedOrder.getDate().ToString();

            pictureBox_isPayed.Image = selectedOrder.isPayed() ? Properties.Resources.etatOk : Properties.Resources.etatNotOk;
            btn_pay.Visible = !selectedOrder.isPayed();
            btn_pay.Enabled = !selectedOrder.isPayed();

            pictureBox_isExpedited.Image = selectedOrder.isExpedited() ? Properties.Resources.etatOk : Properties.Resources.etatNotOk;
            btn_send.Visible = !selectedOrder.isExpedited() && selectedOrder.isPayed();
            btn_send.Enabled = !selectedOrder.isExpedited() && selectedOrder.isPayed();
        }

        private void FmOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ordersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ordersDataGridView.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            this.ordersDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            // Lorsque la cellule d'une commande est cliqué
            if (ordersDataGridView.CurrentCell.ColumnIndex == 0 || ordersDataGridView.CurrentCell.ColumnIndex == 2)
            {   /*
                if (ordersDataGridView.DataSource != allOrders)
                {
                    this.setOrderDataSource(allOrders);
                    if(isClientSearch()) this.resetSearchClient();
                    if(isOrderSearch()) this.resetSearchOrder();
                };
                */
                this.ordersDataGridView.CurrentCell = ordersDataGridView.Rows[this.ordersDataGridView.CurrentCell.RowIndex].Cells[0];
                this.getAllSelectedOrderInfo();
            }
        }

        // filtre "Tout"
        private void checkBox_all_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_all.Checked) return;

            checkBox_toPay.Checked = false;
            checkBox_toSend.Checked = false;

            // Afficher toutes les commandes de la recherche
            if (isOrderSearch())
            {
                this.setOrderDataSource(getSearchedOrder());
                this.getAllSelectedOrderInfo();
                return;
            }
            if (isClientSearch())
            {
                this.setOrderDataSource(getSearchClient());
                this.getAllSelectedOrderInfo();
                return;
            }

            this.setOrderDataSource(allOrders);
            this.getAllSelectedOrderInfo();

        }

        // filtre "à payer"
        private void checkBox_toPay_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_toPay.Checked) return;

            checkBox_all.Checked = false;
            checkBox_toSend.Checked = false;

            // Afficher toutes les commande à payer de la recherche
            if (isOrderSearch())
            {
                this.setOrderDataSource(getSearchedOrder().Where(order => !order.isPayed()).ToList());
                this.getAllSelectedOrderInfo();
                return;
            }
            if (isClientSearch())
            {
                this.setOrderDataSource(getSearchClient().Where(order => !order.isPayed()).ToList());
                this.getAllSelectedOrderInfo();
                return;
            }

            List<Order> allOrdersToPay = allOrders
                .Where(order => !order.isPayed())
                .ToList();

            this.setOrderDataSource(allOrdersToPay);
            this.getAllSelectedOrderInfo();

        }

        // filtre "à expédier"
        private void checkBox_toSend_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_toSend.Checked) return;

            checkBox_all.Checked = false;
            checkBox_toPay.Checked = false;

            // Afficher toutes les commande à expédier de la recherche
            if (isOrderSearch())
            {
                this.setOrderDataSource(getSearchedOrder().Where(order => order.isPayed() && !order.isExpedited()).ToList());
                this.getAllSelectedOrderInfo();
                return;
            }
            if (isClientSearch())
            {
                this.setOrderDataSource(getSearchClient().Where(order => order.isPayed() && !order.isExpedited()).ToList());
                this.getAllSelectedOrderInfo();
                return;
            }

            List<Order> allOrdersToSend = allOrders
                .Where(order => !order.isExpedited() && order.isPayed())
                .ToList();

            this.setOrderDataSource(allOrdersToSend);
            this.getAllSelectedOrderInfo();

        }

        // RECHERCHE SPÉCIFIQUE (Client)

        // Recherche client
        private List<Order> getSearchClient()
        {
            List<Order> ordersList = new List<Order>();
            // Si input de recherche contient bien un entier
            if (textBox_search_client.Text != null && int.TryParse(textBox_search_client.Text, out int searchedClientId))
            {
                // On désactive l'autre recherche si il y en a une
                resetSearchOrder();

                // On modifie le DataSource
                List<Order> ordersListByClientId = allOrders.Where(order => order.getClient().getId() == searchedClientId).ToList();
                if (ordersListByClientId.Count > 0)
                {

                    this.setOrderDataSource(ordersListByClientId);
                    this.getAllSelectedOrderInfo();
                    textBox_search_client.ForeColor = Color.White;
                    textBox_search_client.BackColor = Color.Purple;
                    groupBox_client.ForeColor = Color.Purple;
                    groupBox_client.Text = "Client (Recherche spécifique)";

                    ordersList = ordersListByClientId;
                }
            }
            return ordersList;
        }

        // reset recherche d'un client
        private void resetSearchClient()
        {
            checkBox_search_client.Checked = false;
            textBox_search_client.Text = "";
        }

        // vérif si recherche d'un client
        private bool isClientSearch()
        {
            if (textBox_search_client.Text != null && int.TryParse(textBox_search_client.Text, out int searchedClientId) && checkBox_search_client.Checked) return true;
            return false;
        }

        // Recherche Commande
        private List<Order> getSearchedOrder()
        {
            List<Order> searchedOrderList = new List<Order>();
            // Si input de recherche contient bien un entier
            if (textBox_search_order.Text != null && int.TryParse(textBox_search_order.Text, out int searchedOrderId))
            {
                // On désactive l'autre recherche si il y en a une
                resetSearchClient();

                // On modifie le DataSource
                List<Order> ordersList = allOrders.Where(order => order.getId() == searchedOrderId).ToList();
                if (ordersList.Count > 0)
                {

                    this.setOrderDataSource(ordersList);
                    this.getAllSelectedOrderInfo();
                    textBox_search_order.ForeColor = Color.White;
                    textBox_search_order.BackColor = Color.Purple;
                    groupBox_order.ForeColor = Color.Purple;
                    groupBox_order.Text = "Commande (Recherche spécifique)";

                    searchedOrderList = ordersList;
                }
            }
            return searchedOrderList;
        }

        // reset recherche d'une commande
        private void resetSearchOrder()
        {
            checkBox_search_order.Checked = false;
            textBox_search_order.Text = "";
        }

        // vérif si recherche d'une commande en cours
        private bool isOrderSearch()
        {
            if (textBox_search_order.Text != null && int.TryParse(textBox_search_order.Text, out int searchedOrderId) && checkBox_search_order.Checked) return true;
            return false;
        }

        // checkbox recherche d'un client
        private void checkBox_search_client_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_search_client.Checked)
            {
                this.getSearchClient();
            }
            else
            {
                //this.setOrderDataSource(allOrders);
                //this.getAllSelectedOrderInfo();
                if (!checkBox_all.Checked)
                {
                    checkBox_all.Checked = true;
                }

                textBox_search_client.ForeColor = Color.Black;
                textBox_search_client.BackColor = Color.White;
                groupBox_client.ForeColor = Color.OrangeRed;
            }
        }

        // checkbox recherche d'une commande
        private void checkBox_search_order_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_search_order.Checked)
            {
                this.getSearchedOrder();
            }
            else
            {
                //this.setOrderDataSource(allOrders);
                //this.getAllSelectedOrderInfo();
                if (!checkBox_all.Checked)
                {
                    checkBox_all.Checked = true;
                }
                textBox_search_order.ForeColor = Color.Black;
                textBox_search_order.BackColor = Color.White;
                groupBox_order.ForeColor = Color.OrangeRed;
            }
        }

        // update de la recherche d'une commande on key press
        private void textBox_search_order_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_search_order.Checked)
            {
                this.getSearchedOrder();
            }
        }

        // update de la recherche d'un client on key press
        private void textBox_search_client_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_search_client.Checked)
            {
                this.getSearchClient();
            }
        }

        // GENERATE PDF
        private void generatePDF(object sender, EventArgs e)
        {
            // current cell order Id
            if (ordersDataGridView.CurrentCell == null) return;
            int orderId = int.Parse(ordersDataGridView.CurrentCell.Value.ToString());

            Order selectedOrder = OrderModel.findOrderById(orderId);
            selectedOrder.setOrderRows(OrderRowModel.findAllByOrder(selectedOrder));


            // Chemin PDF
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string pdfFilePath = Path.Combine(downloadsPath, $"cmd-{selectedOrder.getId()}.pdf");

            // new Document
            PdfDocument PdfDocument = new PdfDocument(new PdfWriter(pdfFilePath));
            iText.Layout.Document document = new iText.Layout.Document(PdfDocument);
            try
            {


                // Add title
                document.Add(new Paragraph($"Liste de collisage de la commande n°{selectedOrder.getId()} \n")
                    .SetFontSize(12)
                    .SetTextAlignment(TextAlignment.CENTER));
                // Create table (Product Ref, Designation, Quantity)
                Table table = new Table(3);
                table.SetWidth(UnitValue.CreatePercentValue(100));

                // Add table headers
                table.AddCell("Réf du produit");
                table.AddCell("Désignation");
                table.AddCell("Quantité");

                int? allQuantity = 0;

                // On boucle sur chaque orderRow
                foreach (OrderRow orderRow in selectedOrder.getOrderRows())
                {
                    table.AddCell(orderRow.getProduct().getId().ToString());
                    table.AddCell(orderRow.getProduct().getDesignation());
                    table.AddCell(orderRow.getQuantity().ToString());

                    allQuantity += orderRow.getQuantity();
                }

                // Add table to the document
                document.Add(table);

                document.Add(new Paragraph("Veillez à bien contrôler le contenu du colis à l'aide de cette liste devant le transporteur.")
                    .SetFontSize(8)
                    .SetFontColor(iText.Kernel.Colors.ColorConstants.RED)
                    .SetTextAlignment(TextAlignment.CENTER)
                    );

                document.Add(new Paragraph($"Le colis contient {allQuantity} articles.")
                    .SetFontSize(12)
                    );

                MessageBox.Show("PDF généré avec succès.");
                OpenPDF(pdfFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue lors de la génération du PDF : {ex.Message}");
            }
            finally
            {
                // Close the document and writer
                document.Close();
            }
        }
        private void OpenPDF(string filePath)
        {
            try
            {
                // Cross-platform way to open a file
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    // Windows
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    // Linux
                    Process.Start("xdg-open", filePath);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    // macOS
                    Process.Start("open", filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while opening PDF: {ex.Message}");
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            Order orderToPay = allOrders.Find(order => order.getId() == int.Parse(ordersDataGridView.CurrentCell.Value.ToString()));
            orderToPay.setIsPayed(true);
            OrderModel.payOrderById(orderToPay.getId());
            checkBox_toSend.Checked = true;
            foreach (DataGridViewRow row in ordersDataGridView.Rows)
            {
                if (int.Parse(row.Cells[0].Value.ToString()) == orderToPay.getId())
                {
                    ordersDataGridView.CurrentCell = row.Cells[0];
                }
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Order orderToSend = allOrders.Find(order => order.getId() == int.Parse(ordersDataGridView.CurrentCell.Value.ToString()));
            orderToSend.setIsExpedited(true);
            OrderModel.sendOrderById(orderToSend.getId());
            checkBox_all.Checked = true;
            foreach (DataGridViewRow row in ordersDataGridView.Rows)
            {
                if (int.Parse(row.Cells[0].Value.ToString()) == orderToSend.getId())
                {
                    ordersDataGridView.CurrentCell = row.Cells[0];
                }
            }
        }
                
        private void orderRowsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.orderRowsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.orderRowsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            // Lorsque la cellule d'un produit est cliqué
            if (ordersDataGridView.CurrentCell.ColumnIndex == 0)
            {
                fmProduct productForm = new fmProduct(int.Parse(orderRowsDataGridView.CurrentCell.Value.ToString()));
                productForm.ShowDialog();
            }
        }
    }
}