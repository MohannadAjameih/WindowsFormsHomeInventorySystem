using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using WindowsFormsHomeInventorySystem.Data;

namespace WindowsFormsHomeInventorySystem
{
    public partial class frmOrder : Form
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = E:\\Visual Studio\\WindowsFormsHomeInventorySystem\\Database2022.accdb";
        private static OleDbConnection connection = new OleDbConnection(connectionString);

        Items CreateItem;


        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {


            try
            {
                connection.Open();
                OleDbCommand sc = new OleDbCommand("select (ItemsName) from Items", connection);
                OleDbDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ItemsName", typeof(string));
                dt.Load(reader);
                comItems.ValueMember = "ItemsName";
                comItems.DataSource = dt;
                connection.Close();

            }
            catch (Exception)
            {

            }
        }

        private void comItems_SelectedIndexChanged(object sender, EventArgs e)
        {


            
            OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\Visual Studio\\WindowsFormsHomeInventorySystem\\Database2022.accdb");
            string conn = "select * from Items where ItemsName= '" + comItems.Text+"';";
            OleDbCommand cmd = new OleDbCommand(conn, connection);
            OleDbDataReader myreader;

            try
            {
                connection.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string Quantity = myreader.GetValue(3).ToString();
                    txtQuantity.Text = Quantity;
                    string Unit = myreader.GetValue(2).ToString();
                    txtUnit.Text = Unit;
                } 
                 
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            int test = 0;
            bool parsable1 = int.TryParse(txtAddQuantity.Text, out test);

            bool parsable2 = int.TryParse(txtQuantity.Text, out test);


            if (!parsable1 || !parsable2)
            {
                MessageBox.Show("Item Add Quantity Is Empty");
            }
            else
            {
                int firstNumber = int.Parse(txtAddQuantity.Text);
                int secondNumber = int.Parse(txtQuantity.Text);

                int result = firstNumber + secondNumber;

                txtQuantity.Text = result.ToString();


            }

            OrderQuantity product1 = new OrderQuantity();
            product1.ItemName = comItems.Text;
            product1.Quantity = txtAddQuantity.Text;
            product1.Unit = txtUnit.Text;
            OrderQuantityDAL.CreateOrder(product1);
            ClearForm();
            

        }

        private void txtAddQuantity_TextChanged(object sender, EventArgs e)
        {

            string tString = txtAddQuantity.Text;
            if (tString == "")
                return;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    MessageBox.Show("Please enter a valid Number");
                    txtAddQuantity.Text = "";
                    return;
                }
            }
            //RefreshStudentGridview()
        }
        private void ClearForm()
        {
            txtAddQuantity.Text = "";
            comItems.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
          
        }
       
    }
}
