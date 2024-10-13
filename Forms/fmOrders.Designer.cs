namespace Menagelec.Forms
{
    partial class fmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmOrders));
            lb_title = new Label();
            ordersDataGridView = new DataGridView();
            lb_orderCount = new Label();
            lb_orderList = new Label();
            checkBox_all = new CheckBox();
            checkBox_toPay = new CheckBox();
            checkBox_toSend = new CheckBox();
            lb_selectedOrderInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.BackColor = Color.Transparent;
            lb_title.Font = new Font("Microsoft Sans Serif", 14.25F);
            lb_title.ForeColor = SystemColors.ControlLightLight;
            lb_title.Location = new Point(363, 9);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(220, 24);
            lb_title.TabIndex = 0;
            lb_title.Text = "Gestion des commandes";
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.AllowUserToResizeColumns = false;
            ordersDataGridView.AllowUserToResizeRows = false;
            ordersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ordersDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Location = new Point(12, 141);
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.ReadOnly = true;
            ordersDataGridView.RowHeadersVisible = false;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ordersDataGridView.Size = new Size(299, 488);
            ordersDataGridView.TabIndex = 1;
            ordersDataGridView.CellClick += ordersDataGridView_CellClick;
            // 
            // lb_orderCount
            // 
            lb_orderCount.AutoSize = true;
            lb_orderCount.BackColor = Color.Transparent;
            lb_orderCount.Font = new Font("Microsoft Sans Serif", 8.25F);
            lb_orderCount.ForeColor = SystemColors.ControlLightLight;
            lb_orderCount.Location = new Point(12, 123);
            lb_orderCount.Name = "lb_orderCount";
            lb_orderCount.Size = new Size(115, 13);
            lb_orderCount.TabIndex = 2;
            lb_orderCount.Text = "Nombre d'éléments :    ";
            // 
            // lb_orderList
            // 
            lb_orderList.AutoSize = true;
            lb_orderList.BackColor = Color.Transparent;
            lb_orderList.Font = new Font("Microsoft Sans Serif", 12F);
            lb_orderList.ForeColor = SystemColors.ControlLightLight;
            lb_orderList.Location = new Point(74, 47);
            lb_orderList.Name = "lb_orderList";
            lb_orderList.Size = new Size(164, 20);
            lb_orderList.TabIndex = 3;
            lb_orderList.Text = "Liste des commandes";
            // 
            // checkBox_all
            // 
            checkBox_all.AutoSize = true;
            checkBox_all.BackColor = Color.Transparent;
            checkBox_all.Checked = true;
            checkBox_all.CheckState = CheckState.Checked;
            checkBox_all.ForeColor = SystemColors.ControlLightLight;
            checkBox_all.Location = new Point(44, 92);
            checkBox_all.Name = "checkBox_all";
            checkBox_all.Size = new Size(49, 19);
            checkBox_all.TabIndex = 4;
            checkBox_all.Text = "Tout";
            checkBox_all.UseVisualStyleBackColor = false;
            checkBox_all.CheckedChanged += checkBox_all_CheckedChanged;
            // 
            // checkBox_toPay
            // 
            checkBox_toPay.AutoSize = true;
            checkBox_toPay.BackColor = Color.Transparent;
            checkBox_toPay.ForeColor = SystemColors.ControlLightLight;
            checkBox_toPay.Location = new Point(118, 92);
            checkBox_toPay.Name = "checkBox_toPay";
            checkBox_toPay.Size = new Size(66, 19);
            checkBox_toPay.TabIndex = 5;
            checkBox_toPay.Text = "A payer";
            checkBox_toPay.UseVisualStyleBackColor = false;
            checkBox_toPay.CheckedChanged += checkBox_toPay_CheckedChanged;
            // 
            // checkBox_toSend
            // 
            checkBox_toSend.AutoSize = true;
            checkBox_toSend.BackColor = Color.Transparent;
            checkBox_toSend.ForeColor = SystemColors.ControlLightLight;
            checkBox_toSend.Location = new Point(212, 92);
            checkBox_toSend.Name = "checkBox_toSend";
            checkBox_toSend.Size = new Size(82, 19);
            checkBox_toSend.TabIndex = 6;
            checkBox_toSend.Text = "A expédier";
            checkBox_toSend.UseVisualStyleBackColor = false;
            checkBox_toSend.CheckedChanged += checkBox_toSend_CheckedChanged;
            // 
            // lb_selectedOrderInfo
            // 
            lb_selectedOrderInfo.BackColor = Color.Transparent;
            lb_selectedOrderInfo.Enabled = false;
            lb_selectedOrderInfo.Font = new Font("Microsoft Sans Serif", 12F);
            lb_selectedOrderInfo.ForeColor = SystemColors.ControlLightLight;
            lb_selectedOrderInfo.Location = new Point(363, 47);
            lb_selectedOrderInfo.Name = "lb_selectedOrderInfo";
            lb_selectedOrderInfo.Size = new Size(220, 44);
            lb_selectedOrderInfo.TabIndex = 7;
            lb_selectedOrderInfo.Text = "Informations de la commande sélectionnée";
            lb_selectedOrderInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // fmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(953, 641);
            Controls.Add(lb_selectedOrderInfo);
            Controls.Add(checkBox_toSend);
            Controls.Add(checkBox_toPay);
            Controls.Add(checkBox_all);
            Controls.Add(lb_orderList);
            Controls.Add(lb_orderCount);
            Controls.Add(ordersDataGridView);
            Controls.Add(lb_title);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmOrders";
            Text = "Gestion des commandes";
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_title;
        private DataGridView ordersDataGridView;
        private Label lb_orderCount;
        private Label lb_orderList;
        private CheckBox checkBox_all;
        private CheckBox checkBox_toPay;
        private CheckBox checkBox_toSend;
        private Label lb_selectedOrderInfo;
    }
}