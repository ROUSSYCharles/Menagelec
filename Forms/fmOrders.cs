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
        }

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

        private void FmOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ordersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ordersDataGridView.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            this.ordersDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
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
            }
        }
    }
}
