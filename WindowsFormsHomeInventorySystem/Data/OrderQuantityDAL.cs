using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using WindowsFormsHomeInventorySystem.Data;


namespace WindowsFormsHomeInventorySystem.Data
{

    public static class OrderQuantityDAL
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = E:\\Visual Studio\\WindowsFormsHomeInventorySystem\\Database2022.accdb";
        private static OleDbConnection connection = new OleDbConnection(connectionString);

        public static void CreateOrder(OrderQuantity orderQuantity)
        {
            string commandText = String.Format("Insert into OrderQuantity(ItemName,Quantity,Unit)" +
            "Values('{0}','{1}','{2}')", orderQuantity.ItemName,orderQuantity.Quantity,orderQuantity.Unit);

            OleDbCommand command = new OleDbCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetAllCommand()
        {
            string commandText = string.Format("Select * from OrderQuantity");

            OleDbCommand command = new OleDbCommand(commandText, connection);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


    }

}
