namespace Menagelec.Forms
{
    partial class fmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMenu));
            lb_orders = new Label();
            btn_orders = new Button();
            SuspendLayout();
            // 
            // lb_orders
            // 
            lb_orders.AutoSize = true;
            lb_orders.BackColor = Color.Transparent;
            lb_orders.Font = new Font("Microsoft Sans Serif", 12F);
            lb_orders.ForeColor = SystemColors.ControlLightLight;
            lb_orders.Location = new Point(119, 56);
            lb_orders.Name = "lb_orders";
            lb_orders.Size = new Size(186, 20);
            lb_orders.TabIndex = 2;
            lb_orders.Text = "Gestion des commandes";
            // 
            // btn_orders
            // 
            btn_orders.Image = Properties.Resources.commande_impayee;
            btn_orders.Location = new Point(30, 34);
            btn_orders.Name = "btn_orders";
            btn_orders.Size = new Size(73, 67);
            btn_orders.TabIndex = 4;
            btn_orders.UseVisualStyleBackColor = true;
            // 
            // fmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(333, 327);
            Controls.Add(btn_orders);
            Controls.Add(lb_orders);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmMenu";
            Text = "Menagelec - Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_orders;
        private Button btn_orders;
    }
}