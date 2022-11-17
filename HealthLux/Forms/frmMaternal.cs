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
    public partial class frmMaternal : Form
    {
        //shown panel
        string panel;

        public frmMaternal()
        {
            InitializeComponent();
        }

        private void frmMaternal_Load(object sender, EventArgs e)
        {
            p1.BringToFront();
            panel = "p1";
            lblMainHeader.Text = "Maternal Information Sheet #1";
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.OliveDrab;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DimGray;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (panel.Equals("p5"))
            {
                panel = "p4";
                p4.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #4";
            }
            else if (panel.Equals("p4"))
            {
                panel = "p3";
                p3.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #3";
            }
            else if (panel.Equals("p3"))
            {
                panel = "p2";
                p2.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #2";
            }
            else if (panel.Equals("p2"))
            {
                panel = "p1";
                p1.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #1";
            }
            else if (panel.Equals("p1"))
            {
                panel = "p5";
                p5.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #5";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (panel.Equals("p1"))
            {
                panel = "p2";
                p2.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #2";
            }
            else if (panel.Equals("p2"))
            {
                panel = "p3";
                p3.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #3";
            }
            else if (panel.Equals("p3"))
            {
                panel = "p4";
                p4.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #4";
            }
            else if (panel.Equals("p4"))
            {
                panel = "p5";
                p5.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #5";
            }
            else if (panel.Equals("p5"))
            {
                panel = "p1";
                p1.BringToFront();
                lblMainHeader.Text = "Maternal Information Sheet #1";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
