using Menagelec.Entities;
using Menagelec.src.Models;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.ordersDataGridView.CurrentCell = ordersDataGridView.Rows[0].Cells[0];
        }

        // Obtenir toutes les informations sur la commande sélectionnée
        private void getAllSelectedOrderInfo()
        {
            // selected order infos
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
            pictureBox_isPayed.Image =  selectedOrder.isPayed() ? Properties.Resources.etatOk : Properties.Resources.etatNotOk;
            pictureBox_isExpedited.Image =  selectedOrder.isExpedited() ? Properties.Resources.etatOk : Properties.Resources.etatNotOk;
            
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
            if (ordersDataGridView.CurrentCell.ColumnIndex == 0 ) 
            {
                this.getAllSelectedOrderInfo();
            }
        }

        private void checkBox_all_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_all.Checked)
            {
                checkBox_toPay.Checked = false;
                checkBox_toSend.Checked = false;

                this.setOrderDataSource(allOrders);

                this.getAllSelectedOrderInfo();
            }
        }

        private void checkBox_toPay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_toPay.Checked)
            {
                checkBox_all.Checked = false;
                checkBox_toSend.Checked = false;

                List<Order> allOrdersToPay = new List<Order>();
                foreach (Order order in allOrders)
                {
                    if(!order.isPayed())
                    {
                        allOrdersToPay.Add(order);
                    }
                }

                this.setOrderDataSource(allOrdersToPay);

                this.getAllSelectedOrderInfo();
            }
        }

        private void checkBox_toSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_toSend.Checked)
            {
                checkBox_all.Checked = false;
                checkBox_toPay.Checked = false;

                List<Order> allOrdersToSend = new List<Order>();
                foreach (Order order in allOrders)
                {
                    if (!order.isExpedited() && order.isPayed())
                    {
                        allOrdersToSend.Add(order);
                    }
                }

                this.setOrderDataSource(allOrdersToSend);

                this.getAllSelectedOrderInfo();
            }
        }
    }
}
