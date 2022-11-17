using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthLux
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Forms.frmMain fM = new Forms.frmMain();
            fM.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.OliveDrab;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.LightGray;
            btnClose.ForeColor = Color.FromArgb(50, 50, 50);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = Color.FromArgb(50, 50, 50);
        }

        private void Textbox_Enter(object sender, EventArgs e)
        {
            txtUsername.Border.BorderColor = Color.OliveDrab;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            txtUsername.Border.BorderColor = Color.OliveDrab;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtUsername.Border.BorderColor = Color.FromArgb(198, 195, 198);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Border.BorderColor = Color.OliveDrab;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.Border.BorderColor = Color.FromArgb(198, 195, 198);
        }
    }
}
