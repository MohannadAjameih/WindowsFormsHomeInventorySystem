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
    public static class ItemsDAL
    {
        private static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = E:\\Visual Studio\\WindowsFormsHomeInventorySystem\\Database2022.accdb";
        private static OleDbConnection connection = new OleDbConnection(connectionString);


        public static void CreateItem(Items items)
        {
            string commandText = String.Format("Insert into Items(ItemsName,Unit,Quantity)" +
            "Values('{0}','{1}','{2}')", items.ItemsName, items.Unit, items.Quantity);

            OleDbCommand command = new OleDbCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }

        public static void DeleteCommand(Items items)
        {
            string commandText = string.Format("Delete from Items" +
                " where ItemId = {0}"
                , items.ItemId);

            OleDbCommand command = new OleDbCommand(commandText, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateCommand(Items items)
        {

            string updateCommand = string.Format("Update Items Set ItemsName = '{1}', Unit = '{2}',Quantity = '{3}'" +
                " where ItemId = {0}", items.ItemId, items.ItemsName, items.Unit, items.Quantity);

            OleDbCommand command = new OleDbCommand(updateCommand, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable GetAllCommand()
        {
            string commandText = string.Format("Select * from Items");

            OleDbCommand command = new OleDbCommand(commandText, connection);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        
    }
}
