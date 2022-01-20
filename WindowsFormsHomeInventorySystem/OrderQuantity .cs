using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsHomeInventorySystem.Data;

namespace WindowsFormsHomeInventorySystem
{
    public partial class frmOrderQuantity : Form
    {

        OrderQuantity CreateOrder;

        public frmOrderQuantity()
        {
            InitializeComponent();
        }

        private void RefreshStudentGridview()
        {
            dataGridViewOrder.DataSource = OrderQuantityDAL.GetAllCommand();

        }


        private void OrderQuantity_Load(object sender, EventArgs e)
        {
            RefreshStudentGridview();

        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreateOrder = new OrderQuantity();
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridViewOrder.Rows[e.RowIndex];
            CreateOrder.OrderId = int.Parse(row.Cells[0].Value.ToString());
            CreateOrder.ItemName = row.Cells[1].Value.ToString();
            CreateOrder.Quantity = row.Cells[2].Value.ToString();
            CreateOrder.Unit = row.Cells[3].Value.ToString();


        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "ItemName";
            chart1.Series[0].YValueMembers = "ItemName";

            chart1.Series[1].XValueMember = "Quantity";
            chart1.Series[1].YValueMembers = "Quantity";

            chart1.DataSource = OrderQuantityDAL.GetAllCommand();
            chart1.DataBind (); 
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
