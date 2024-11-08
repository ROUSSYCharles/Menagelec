namespace Menagelec.Forms
{
    partial class fmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
            pictureBox1 = new PictureBox();
            lb_username = new Label();
            lb_password = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            btn_login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_menagelec;
            pictureBox1.Location = new Point(61, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.BackColor = Color.Transparent;
            lb_username.Font = new Font("Microsoft Sans Serif", 14.25F);
            lb_username.Location = new Point(461, 57);
            lb_username.Margin = new Padding(2, 0, 2, 0);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(90, 24);
            lb_username.TabIndex = 1;
            lb_username.Text = "Utilisateur";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.BackColor = Color.Transparent;
            lb_password.Font = new Font("Microsoft Sans Serif", 14.25F);
            lb_password.Location = new Point(461, 157);
            lb_password.Margin = new Padding(2, 0, 2, 0);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(123, 24);
            lb_password.TabIndex = 2;
            lb_password.Text = "Mot de passe";
            // 
            // tb_username
            // 
            tb_username.Font = new Font("Microsoft Sans Serif", 8F);
            tb_username.Location = new Point(461, 99);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(235, 20);
            tb_username.TabIndex = 3;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Microsoft Sans Serif", 8F);
            tb_password.Location = new Point(461, 194);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(235, 20);
            tb_password.TabIndex = 4;
            tb_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.LightGray;
            btn_login.Font = new Font("Microsoft Sans Serif", 12F);
            btn_login.ForeColor = SystemColors.ActiveCaptionText;
            btn_login.Location = new Point(461, 283);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(235, 34);
            btn_login.TabIndex = 5;
            btn_login.Text = "Se connecter";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // fmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(800, 431);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(lb_password);
            Controls.Add(lb_username);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "fmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menagelec - Accès à l'application";
            FormClosed += fmLogin_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_username;
        private Label lb_password;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button btn_login;
    }
}