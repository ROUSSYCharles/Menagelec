﻿using Menagelec.Entities;
using Menagelec.src.Models;
using System.Data;

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
            pictureBox_isExpedited.Image = selectedOrder.isExpedited() ? Properties.Resources.etatOk : Properties.Resources.etatNotOk;

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
            if (textBox_search_client.Text != null && int.TryParse(textBox_search_client.Text, out int searchedClientId)) return true;
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
            if (textBox_search_order.Text != null && int.TryParse(textBox_search_order.Text, out int searchedOrderId)) return true;
            return false;
        }

        // checkbox recherche d'un client
        private void checkBox_search_client_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_search_client.Checked)
            {
                this.getSearchClient();
            }
            else if (ordersDataGridView.DataSource != allOrders)
            {
                this.setOrderDataSource(allOrders);
                this.getAllSelectedOrderInfo();
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
            else if (ordersDataGridView.DataSource != allOrders)
            {
                this.setOrderDataSource(allOrders);
                this.getAllSelectedOrderInfo();
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
    }
}
