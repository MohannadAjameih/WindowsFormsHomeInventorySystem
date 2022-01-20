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
    public partial class frmItems : Form
    {

        Items CreateItem;

        public frmItems()
        {
            InitializeComponent();
        }


        private void RefreshStudentGridview()
        {
            dataGridView1.DataSource = ItemsDAL.GetAllCommand();
        }


        private void frmItems_Load(object sender, EventArgs e)
        {
            RefreshStudentGridview();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

           
            if (txtItemName.Text.Length == 0)
            {
                MessageBox.Show("Item Name Is Empty");
            }
            else
            {
                Items product = new Items();
                product.ItemsName = txtItemName.Text;
                product.Unit = comUnit.Text;
                product.Quantity = txtQuantity.Text;
                ItemsDAL.CreateItem(product);
                RefreshStudentGridview();
                ClearForm();
            }

        }


        private void ClearForm()
        {
            txtItemName.Text = "";
            txtQuantity.Text = "";
            comUnit.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemsDAL.DeleteCommand(CreateItem);
            ClearForm();
            RefreshStudentGridview();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtItemName.Text.Length == 0)
            {
                MessageBox.Show("Item Name Is Empty");
            }
            else
            {
                CreateItem.ItemsName = txtItemName.Text;
                CreateItem.Unit = comUnit.Text;
                CreateItem.Quantity = txtQuantity.Text;

                ItemsDAL.UpdateCommand(CreateItem);
                RefreshStudentGridview();
                ClearForm();
            }
                
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            string tString = txtQuantity.Text;
            if (tString == "")
                return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid Number");
                    txtQuantity.Text = "";
                    return;
                }
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CreateItem = new Items();
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            CreateItem.ItemId = int.Parse(row.Cells[0].Value.ToString());
            CreateItem.ItemsName = row.Cells[1].Value.ToString();
            CreateItem.Unit = row.Cells[2].Value.ToString();
            CreateItem.Quantity = row.Cells[3].Value.ToString();

            txtItemName.Text = CreateItem.ItemsName.ToString();
            comUnit.Text = CreateItem.Unit.ToString();
            txtQuantity.Text = CreateItem.Quantity.ToString();


        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
