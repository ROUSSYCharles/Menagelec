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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            groupBox_order = new GroupBox();
            btn_send = new Button();
            btn_pay = new Button();
            pictureBox_isExpedited = new PictureBox();
            lb_expedition = new Label();
            pictureBox_isPayed = new PictureBox();
            lb_paiement = new Label();
            lb_order_date = new Label();
            lb_date = new Label();
            lb_orderRowsCount = new Label();
            orderRowsDataGridView = new DataGridView();
            lb_search = new Label();
            lb_search_client = new Label();
            textBox_search_client = new TextBox();
            checkBox_search_client = new CheckBox();
            checkBox_search_order = new CheckBox();
            textBox_search_order = new TextBox();
            lb_search_order = new Label();
            lb_documents = new Label();
            btn_login = new Button();
            btn_menu = new Button();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            groupBox_client.SuspendLayout();
            groupBox_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_isExpedited).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_isPayed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderRowsDataGridView).BeginInit();
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
            ordersDataGridView.BackgroundColor = SystemColors.ControlLightLight;
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
            // groupBox_order
            // 
            groupBox_order.Controls.Add(btn_send);
            groupBox_order.Controls.Add(btn_pay);
            groupBox_order.Controls.Add(pictureBox_isExpedited);
            groupBox_order.Controls.Add(lb_expedition);
            groupBox_order.Controls.Add(pictureBox_isPayed);
            groupBox_order.Controls.Add(lb_paiement);
            groupBox_order.Controls.Add(lb_order_date);
            groupBox_order.Controls.Add(lb_date);
            resources.ApplyResources(groupBox_order, "groupBox_order");
            groupBox_order.ForeColor = Color.OrangeRed;
            groupBox_order.Name = "groupBox_order";
            groupBox_order.TabStop = false;
            // 
            // btn_send
            // 
            resources.ApplyResources(btn_send, "btn_send");
            btn_send.ForeColor = Color.SeaGreen;
            btn_send.Name = "btn_send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // btn_pay
            // 
            resources.ApplyResources(btn_pay, "btn_pay");
            btn_pay.ForeColor = Color.SeaGreen;
            btn_pay.Name = "btn_pay";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += btn_pay_Click;
            // 
            // pictureBox_isExpedited
            // 
            pictureBox_isExpedited.Image = Properties.Resources.etatOk;
            resources.ApplyResources(pictureBox_isExpedited, "pictureBox_isExpedited");
            pictureBox_isExpedited.Name = "pictureBox_isExpedited";
            pictureBox_isExpedited.TabStop = false;
            // 
            // lb_expedition
            // 
            resources.ApplyResources(lb_expedition, "lb_expedition");
            lb_expedition.Name = "lb_expedition";
            // 
            // pictureBox_isPayed
            // 
            pictureBox_isPayed.Image = Properties.Resources.etatNotOk;
            resources.ApplyResources(pictureBox_isPayed, "pictureBox_isPayed");
            pictureBox_isPayed.Name = "pictureBox_isPayed";
            pictureBox_isPayed.TabStop = false;
            // 
            // lb_paiement
            // 
            resources.ApplyResources(lb_paiement, "lb_paiement");
            lb_paiement.Name = "lb_paiement";
            // 
            // lb_order_date
            // 
            resources.ApplyResources(lb_order_date, "lb_order_date");
            lb_order_date.Name = "lb_order_date";
            // 
            // lb_date
            // 
            resources.ApplyResources(lb_date, "lb_date");
            lb_date.Name = "lb_date";
            // 
            // lb_orderRowsCount
            // 
            resources.ApplyResources(lb_orderRowsCount, "lb_orderRowsCount");
            lb_orderRowsCount.BackColor = Color.Transparent;
            lb_orderRowsCount.ForeColor = SystemColors.ControlLightLight;
            lb_orderRowsCount.Name = "lb_orderRowsCount";
            // 
            // orderRowsDataGridView
            // 
            orderRowsDataGridView.AllowUserToAddRows = false;
            orderRowsDataGridView.AllowUserToDeleteRows = false;
            orderRowsDataGridView.AllowUserToOrderColumns = true;
            orderRowsDataGridView.AllowUserToResizeColumns = false;
            orderRowsDataGridView.AllowUserToResizeRows = false;
            orderRowsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderRowsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            orderRowsDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            orderRowsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            orderRowsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            orderRowsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(orderRowsDataGridView, "orderRowsDataGridView");
            orderRowsDataGridView.MultiSelect = false;
            orderRowsDataGridView.Name = "orderRowsDataGridView";
            orderRowsDataGridView.ReadOnly = true;
            orderRowsDataGridView.RowHeadersVisible = false;
            orderRowsDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            orderRowsDataGridView.CellClick += orderRowsDataGridView_CellClick;
            // 
            // lb_search
            // 
            resources.ApplyResources(lb_search, "lb_search");
            lb_search.BackColor = Color.Transparent;
            lb_search.ForeColor = SystemColors.ControlLightLight;
            lb_search.Name = "lb_search";
            // 
            // lb_search_client
            // 
            resources.ApplyResources(lb_search_client, "lb_search_client");
            lb_search_client.BackColor = Color.Transparent;
            lb_search_client.ForeColor = SystemColors.ControlLightLight;
            lb_search_client.Name = "lb_search_client";
            // 
            // textBox_search_client
            // 
            resources.ApplyResources(textBox_search_client, "textBox_search_client");
            textBox_search_client.Name = "textBox_search_client";
            textBox_search_client.TextChanged += textBox_search_client_TextChanged;
            // 
            // checkBox_search_client
            // 
            resources.ApplyResources(checkBox_search_client, "checkBox_search_client");
            checkBox_search_client.BackColor = Color.Transparent;
            checkBox_search_client.Name = "checkBox_search_client";
            checkBox_search_client.UseVisualStyleBackColor = false;
            checkBox_search_client.CheckedChanged += checkBox_search_client_CheckedChanged;
            // 
            // checkBox_search_order
            // 
            resources.ApplyResources(checkBox_search_order, "checkBox_search_order");
            checkBox_search_order.BackColor = Color.Transparent;
            checkBox_search_order.Name = "checkBox_search_order";
            checkBox_search_order.UseVisualStyleBackColor = false;
            checkBox_search_order.CheckedChanged += checkBox_search_order_CheckedChanged;
            // 
            // textBox_search_order
            // 
            resources.ApplyResources(textBox_search_order, "textBox_search_order");
            textBox_search_order.Name = "textBox_search_order";
            textBox_search_order.TextChanged += textBox_search_order_TextChanged;
            // 
            // lb_search_order
            // 
            resources.ApplyResources(lb_search_order, "lb_search_order");
            lb_search_order.BackColor = Color.Transparent;
            lb_search_order.ForeColor = SystemColors.ControlLightLight;
            lb_search_order.Name = "lb_search_order";
            // 
            // lb_documents
            // 
            resources.ApplyResources(lb_documents, "lb_documents");
            lb_documents.BackColor = Color.Transparent;
            lb_documents.ForeColor = SystemColors.ControlLightLight;
            lb_documents.Name = "lb_documents";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.LightGray;
            resources.ApplyResources(btn_login, "btn_login");
            btn_login.ForeColor = SystemColors.ActiveCaptionText;
            btn_login.Name = "btn_login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += generatePDF;
            // 
            // btn_menu
            // 
            resources.ApplyResources(btn_menu, "btn_menu");
            btn_menu.Name = "btn_menu";
            btn_menu.UseVisualStyleBackColor = true;
            btn_menu.Click += btn_menu_Click;
            // 
            // fmOrders
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(btn_menu);
            Controls.Add(btn_login);
            Controls.Add(lb_documents);
            Controls.Add(checkBox_search_order);
            Controls.Add(textBox_search_order);
            Controls.Add(lb_search_order);
            Controls.Add(checkBox_search_client);
            Controls.Add(textBox_search_client);
            Controls.Add(lb_search_client);
            Controls.Add(lb_search);
            Controls.Add(orderRowsDataGridView);
            Controls.Add(lb_orderRowsCount);
            Controls.Add(groupBox_order);
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
            MaximizeBox = false;
            Name = "fmOrders";
            FormClosed += FmOrders_FormClosed;
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            groupBox_client.ResumeLayout(false);
            groupBox_client.PerformLayout();
            groupBox_order.ResumeLayout(false);
            groupBox_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_isExpedited).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_isPayed).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderRowsDataGridView).EndInit();
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
        private GroupBox groupBox_order;
        private Label lb_paiement;
        private Label lb_order_date;
        private Label lb_date;
        private PictureBox pictureBox_isExpedited;
        private Label lb_expedition;
        private PictureBox pictureBox_isPayed;
        private Label lb_orderRowsCount;
        private DataGridView orderRowsDataGridView;
        private Label lb_search;
        private Label lb_search_client;
        private TextBox textBox_search_client;
        private CheckBox checkBox_search_client;
        private CheckBox checkBox_search_order;
        private TextBox textBox_search_order;
        private Label lb_search_order;
        private Label lb_documents;
        private Button btn_login;
        private Button btn_send;
        private Button btn_pay;
        private Button btn_menu;
    }
}