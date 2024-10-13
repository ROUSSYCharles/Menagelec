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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lb_title = new Label();
            ordersDataGridView = new DataGridView();
            lb_orderCount = new Label();
            lb_orderList = new Label();
            checkBox_all = new CheckBox();
            checkBox_toPay = new CheckBox();
            checkBox_toSend = new CheckBox();
            lb_selectedOrderInfo = new Label();
            groupBox_client = new GroupBox();
            lb_client_phone = new Label();
            lb_phone_title = new Label();
            lb_client_email = new Label();
            lb_mail_title = new Label();
            lb_city = new Label();
            lb_postalCode = new Label();
            lb_address = new Label();
            lb_name = new Label();
            lb_lastName = new Label();
            lb_civility = new Label();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            groupBox_client.SuspendLayout();
            SuspendLayout();
            // 
            // lb_title
            // 
            resources.ApplyResources(lb_title, "lb_title");
            lb_title.BackColor = Color.Transparent;
            lb_title.ForeColor = SystemColors.ControlLightLight;
            lb_title.Name = "lb_title";
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.AllowUserToOrderColumns = true;
            ordersDataGridView.AllowUserToResizeColumns = false;
            ordersDataGridView.AllowUserToResizeRows = false;
            ordersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ordersDataGridView.BorderStyle = BorderStyle.Fixed3D;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ordersDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(ordersDataGridView, "ordersDataGridView");
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.ReadOnly = true;
            ordersDataGridView.RowHeadersVisible = false;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            ordersDataGridView.CellClick += ordersDataGridView_CellClick;
            // 
            // lb_orderCount
            // 
            resources.ApplyResources(lb_orderCount, "lb_orderCount");
            lb_orderCount.BackColor = Color.Transparent;
            lb_orderCount.ForeColor = SystemColors.ControlLightLight;
            lb_orderCount.Name = "lb_orderCount";
            // 
            // lb_orderList
            // 
            resources.ApplyResources(lb_orderList, "lb_orderList");
            lb_orderList.BackColor = Color.Transparent;
            lb_orderList.ForeColor = SystemColors.ControlLightLight;
            lb_orderList.Name = "lb_orderList";
            // 
            // checkBox_all
            // 
            resources.ApplyResources(checkBox_all, "checkBox_all");
            checkBox_all.BackColor = Color.Transparent;
            checkBox_all.Checked = true;
            checkBox_all.CheckState = CheckState.Checked;
            checkBox_all.ForeColor = SystemColors.ControlLightLight;
            checkBox_all.Name = "checkBox_all";
            checkBox_all.UseVisualStyleBackColor = false;
            checkBox_all.CheckedChanged += checkBox_all_CheckedChanged;
            // 
            // checkBox_toPay
            // 
            resources.ApplyResources(checkBox_toPay, "checkBox_toPay");
            checkBox_toPay.BackColor = Color.Transparent;
            checkBox_toPay.ForeColor = SystemColors.ControlLightLight;
            checkBox_toPay.Name = "checkBox_toPay";
            checkBox_toPay.UseVisualStyleBackColor = false;
            checkBox_toPay.CheckedChanged += checkBox_toPay_CheckedChanged;
            // 
            // checkBox_toSend
            // 
            resources.ApplyResources(checkBox_toSend, "checkBox_toSend");
            checkBox_toSend.BackColor = Color.Transparent;
            checkBox_toSend.ForeColor = SystemColors.ControlLightLight;
            checkBox_toSend.Name = "checkBox_toSend";
            checkBox_toSend.UseVisualStyleBackColor = false;
            checkBox_toSend.CheckedChanged += checkBox_toSend_CheckedChanged;
            // 
            // lb_selectedOrderInfo
            // 
            lb_selectedOrderInfo.BackColor = Color.Transparent;
            resources.ApplyResources(lb_selectedOrderInfo, "lb_selectedOrderInfo");
            lb_selectedOrderInfo.ForeColor = SystemColors.ControlLightLight;
            lb_selectedOrderInfo.Name = "lb_selectedOrderInfo";
            // 
            // groupBox_client
            // 
            groupBox_client.Controls.Add(lb_client_phone);
            groupBox_client.Controls.Add(lb_phone_title);
            groupBox_client.Controls.Add(lb_client_email);
            groupBox_client.Controls.Add(lb_mail_title);
            groupBox_client.Controls.Add(lb_city);
            groupBox_client.Controls.Add(lb_postalCode);
            groupBox_client.Controls.Add(lb_address);
            groupBox_client.Controls.Add(lb_name);
            groupBox_client.Controls.Add(lb_lastName);
            groupBox_client.Controls.Add(lb_civility);
            resources.ApplyResources(groupBox_client, "groupBox_client");
            groupBox_client.ForeColor = Color.OrangeRed;
            groupBox_client.Name = "groupBox_client";
            groupBox_client.TabStop = false;
            // 
            // lb_client_phone
            // 
            resources.ApplyResources(lb_client_phone, "lb_client_phone");
            lb_client_phone.Name = "lb_client_phone";
            // 
            // lb_phone_title
            // 
            resources.ApplyResources(lb_phone_title, "lb_phone_title");
            lb_phone_title.Name = "lb_phone_title";
            // 
            // lb_client_email
            // 
            resources.ApplyResources(lb_client_email, "lb_client_email");
            lb_client_email.Name = "lb_client_email";
            // 
            // lb_mail_title
            // 
            resources.ApplyResources(lb_mail_title, "lb_mail_title");
            lb_mail_title.Name = "lb_mail_title";
            // 
            // lb_city
            // 
            resources.ApplyResources(lb_city, "lb_city");
            lb_city.Name = "lb_city";
            // 
            // lb_postalCode
            // 
            resources.ApplyResources(lb_postalCode, "lb_postalCode");
            lb_postalCode.Name = "lb_postalCode";
            // 
            // lb_address
            // 
            resources.ApplyResources(lb_address, "lb_address");
            lb_address.Name = "lb_address";
            // 
            // lb_name
            // 
            resources.ApplyResources(lb_name, "lb_name");
            lb_name.Name = "lb_name";
            // 
            // lb_lastName
            // 
            resources.ApplyResources(lb_lastName, "lb_lastName");
            lb_lastName.Name = "lb_lastName";
            // 
            // lb_civility
            // 
            resources.ApplyResources(lb_civility, "lb_civility");
            lb_civility.Name = "lb_civility";
            // 
            // fmOrders
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(groupBox_client);
            Controls.Add(lb_selectedOrderInfo);
            Controls.Add(checkBox_toSend);
            Controls.Add(checkBox_toPay);
            Controls.Add(checkBox_all);
            Controls.Add(lb_orderList);
            Controls.Add(lb_orderCount);
            Controls.Add(ordersDataGridView);
            Controls.Add(lb_title);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "fmOrders";
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            groupBox_client.ResumeLayout(false);
            groupBox_client.PerformLayout();
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
        private GroupBox groupBox_client;
        private Label lb_postalCode;
        private Label lb_address;
        private Label lb_name;
        private Label lb_lastName;
        private Label lb_civility;
        private Label lb_client_phone;
        private Label lb_phone_title;
        private Label lb_client_email;
        private Label lb_mail_title;
        private Label lb_city;
    }
}