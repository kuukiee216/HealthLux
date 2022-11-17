using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthLux.Forms
{
    public partial class frmMain : Form
    {
        //Form Size
        Boolean FormMaximized = false;

        //Purok
        string Purok = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ClockTimer.Start();
            lblDividerPath.Text = "Home";
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
            lblTime2.Text = DateTime.Now.ToString("tt");
            lblDayDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void ButtonHeader_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightGray;
        }

        private void ButtonHeader_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.OliveDrab;
            btn.ForeColor = Color.White;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightGray;
            btn.ForeColor = Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogin fL = new frmLogin();
            this.Close();
            fL.Show();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (!FormMaximized)
            {
                this.Size = new Size(1400, 800);
                this.CenterToScreen();
                tblpMain.RowStyles[0].Height = 5 / 100 * Convert.ToInt32(this.Height);
                tblpMain.RowStyles[1].Height = 95 / 100 * Convert.ToInt32(this.Height);
                FormMaximized = true;
            }
            else
            {
                this.Size = new Size(1100, 600);
                this.CenterToScreen();
                tblpMain.RowStyles[0].Height = 7 / 100 * Convert.ToInt32(this.Height);
                tblpMain.RowStyles[1].Height = 93 / 100 * Convert.ToInt32(this.Height);
                FormMaximized = false;
            }
        }

        private void btnPurok1_Click(object sender, EventArgs e)
        {
            pMainMenu2.BringToFront();
            Purok = "1";
            lblDividerPath.Text = "Home > Purok 1";
        }

        private void btnPurok2_Click(object sender, EventArgs e)
        {
            pMainMenu2.BringToFront();
            Purok = "2";
            lblDividerPath.Text = "Home > Purok 2";
        }

        private void btnPurok3_Click(object sender, EventArgs e)
        {
            pMainMenu2.BringToFront();
            Purok = "3";
            lblDividerPath.Text = "Home > Purok 3";
        }

        private void btnPurok4_Click(object sender, EventArgs e)
        {
            pMainMenu2.BringToFront();
            Purok = "4";
            lblDividerPath.Text = "Home > Purok 4";
        }

        private void btnPatientMasterList_Click(object sender, EventArgs e)
        {
            Forms.frmPatientMasterList fPML = new Forms.frmPatientMasterList();
            fPML.ShowDialog();
        }

        private void btnFamilyList_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pMainMenu.BringToFront();
            Purok = "";
            lblDividerPath.Text = "Home";
        }

        private void btnMaternal_Click(object sender, EventArgs e)
        {
            Forms.frmMaternal fM = new Forms.frmMaternal();
            fM.ShowDialog();
        }
    }
}
