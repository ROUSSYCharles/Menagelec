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
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }
        private void fmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if((tb_username.Text == "fournier" &&  tb_password.Text == "1234") || (tb_username.Text == "hurier" && tb_password.Text == "5678"))
            {
                fmMenu formMenu = new fmMenu();
                formMenu.Show();
                this.Hide();
            }
        }
    }
}
