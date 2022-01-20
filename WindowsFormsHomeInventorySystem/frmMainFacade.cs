using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomeInventorySystem
{
    public partial class frmMainFacade : Form
    {

        Form currentFrm;

        public frmMainFacade()
        {
            InitializeComponent();
        }

        private void frmMainFacade_Load(object sender, EventArgs e)
        {
            currentFrm = new frmUserProfile();
            currentFrm.TopLevel = false;
            currentFrm.FormBorderStyle = FormBorderStyle.None;
            panelshow1.Controls.Add(currentFrm);
            currentFrm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnitems_Click(object sender, EventArgs e)
        {
            if (currentFrm != null)
                currentFrm.Close();

            currentFrm = new frmItems();
            currentFrm.TopLevel = false;
            currentFrm.FormBorderStyle = FormBorderStyle.None;

            panelshow1.Controls.Add(currentFrm);

            currentFrm.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            if (currentFrm != null)
                currentFrm.Close();

            currentFrm = new frmUserProfile();
            currentFrm.TopLevel = false;
            currentFrm.FormBorderStyle = FormBorderStyle.None;

            panelshow1.Controls.Add(currentFrm);

            currentFrm.Show();
        }

        private void btnexti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if (currentFrm != null)
                currentFrm.Close();

            currentFrm = new frmOrder();
            currentFrm.TopLevel = false;
            currentFrm.FormBorderStyle = FormBorderStyle.None;

            panelshow1.Controls.Add(currentFrm);

            currentFrm.Show();
        }

        private void btnOrderQ_Click(object sender, EventArgs e)
        {
            if (currentFrm != null)
                currentFrm.Close();

            currentFrm = new frmOrderQuantity();
            currentFrm.TopLevel = false;
            currentFrm.FormBorderStyle = FormBorderStyle.None;

            panelshow1.Controls.Add(currentFrm);

            currentFrm.Show();
        }
    }
}
