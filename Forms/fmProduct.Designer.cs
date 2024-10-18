namespace Menagelec.Forms
{
    partial class fmProduct
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
            product_pb = new PictureBox();
            lb_product_designation = new Label();
            lb_product_description = new Label();
            lb_product_price = new Label();
            ((System.ComponentModel.ISupportInitialize)product_pb).BeginInit();
            SuspendLayout();
            // 
            // product_pb
            // 
            product_pb.ErrorImage = null;
            product_pb.InitialImage = null;
            product_pb.Location = new Point(59, 94);
            product_pb.Name = "product_pb";
            product_pb.Size = new Size(267, 275);
            product_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            product_pb.TabIndex = 0;
            product_pb.TabStop = false;
            // 
            // lb_product_designation
            // 
            lb_product_designation.AutoSize = true;
            lb_product_designation.BackColor = Color.Transparent;
            lb_product_designation.Font = new Font("Microsoft Sans Serif", 14.25F);
            lb_product_designation.ForeColor = SystemColors.ControlLightLight;
            lb_product_designation.Location = new Point(59, 35);
            lb_product_designation.Name = "lb_product_designation";
            lb_product_designation.Size = new Size(181, 24);
            lb_product_designation.TabIndex = 3;
            lb_product_designation.Text = "product_designation";
            // 
            // lb_product_description
            // 
            lb_product_description.AutoEllipsis = true;
            lb_product_description.BackColor = Color.Transparent;
            lb_product_description.Font = new Font("Microsoft Sans Serif", 12F);
            lb_product_description.ForeColor = SystemColors.ControlLightLight;
            lb_product_description.Location = new Point(380, 94);
            lb_product_description.Name = "lb_product_description";
            lb_product_description.Size = new Size(382, 264);
            lb_product_description.TabIndex = 4;
            lb_product_description.Text = "product_description";
            // 
            // lb_product_price
            // 
            lb_product_price.AutoSize = true;
            lb_product_price.BackColor = Color.Transparent;
            lb_product_price.Font = new Font("Microsoft Sans Serif", 12F);
            lb_product_price.ForeColor = SystemColors.ControlLightLight;
            lb_product_price.Location = new Point(59, 390);
            lb_product_price.Name = "lb_product_price";
            lb_product_price.Size = new Size(41, 20);
            lb_product_price.TabIndex = 5;
            lb_product_price.Text = "prix: ";
            // 
            // fmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_product_price);
            Controls.Add(lb_product_description);
            Controls.Add(lb_product_designation);
            Controls.Add(product_pb);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "fmProduct";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "fmProduct";
            ((System.ComponentModel.ISupportInitialize)product_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox product_pb;
        private Label lb_product_designation;
        private Label lb_product_description;
        private Label lb_product_price;
    }
}