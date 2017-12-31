using StackManagement.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StackManagement.Gateway
{
    internal class SaleViewGateway : Gateway
    {
        public List<SaleView> GetAllSaledItems(string fromDate, string toDate)
        {
            string query = "SELECT * FROM saleView WHERE insert_date BETWEEN '" + fromDate + "'AND'" + toDate + "' AND sell_item='Yes'";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<SaleView> items = new List<SaleView>();
            while (reader.Read())
            {
                SaleView item = new SaleView();
                item.itemId = (int)reader["item_id"];
                item.itemName = reader["itemName"].ToString();
                item.takenQuentity = reader["takenQuentity"].ToString();

                items.Add(item);
            }
            reader.Close();
            Connection.Close();
            return items;
        }
    }
}