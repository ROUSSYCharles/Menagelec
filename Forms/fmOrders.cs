using Menagelec.Entities;
using Menagelec.src.Models;
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

            // DataGridView
            DataTable orderDataTable = createOrderDt(allOrders);
            this.ordersDataGridView.DataSource = orderDataTable;
            lb_orderCount.Text = $"Nombre d'éléments :   {allOrders.Count()}";
            // groupBox_client
            ordersDataGridView.CurrentCell = ordersDataGridView.Rows[0].Cells[0];
            this.getOrderClientInformations();

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

        // Obtenir les informations du client de la commande sélectionnée
        private void getOrderClientInformations()
        {
            Order selectedOrder = OrderModel.findOrderById(int.Parse(this.ordersDataGridView.CurrentCell.Value.ToString()));
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
                // On remplit la groupBox_client
                this.getOrderClientInformations();
            }
        }

        private void checkBox_all_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_all.Checked)
            {
                checkBox_toPay.Checked = false;
                checkBox_toSend.Checked = false;

                DataTable orderDataTable = createOrderDt(allOrders);
                this.ordersDataGridView.DataSource = orderDataTable;
                lb_orderCount.Text = $"Nombre d'éléments :   {allOrders.Count()}";
                ordersDataGridView.CurrentCell = ordersDataGridView.Rows[0].Cells[0];

                this.getOrderClientInformations();
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
                DataTable orderToPayDt = createOrderDt(allOrdersToPay);
                this.ordersDataGridView.DataSource = orderToPayDt;
                lb_orderCount.Text = $"Nombre d'éléments :   {allOrdersToPay.Count()}";
                ordersDataGridView.CurrentCell = ordersDataGridView.Rows[0].Cells[0];

                this.getOrderClientInformations();
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
                    if (!order.isExpedited())
                    {
                        allOrdersToSend.Add(order);
                    }
                }
                DataTable orderToPayDt = createOrderDt(allOrdersToSend);
                this.ordersDataGridView.DataSource = orderToPayDt;
                lb_orderCount.Text = $"Nombre d'éléments :   {allOrdersToSend.Count()}";
                ordersDataGridView.CurrentCell = ordersDataGridView.Rows[0].Cells[0];

                this.getOrderClientInformations();
            }
        }
    }
}
