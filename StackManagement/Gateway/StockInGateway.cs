using StackManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StackManagement.Gateway
{
    internal class StockInGateway : Gateway
    {
        public int SaveStock(StockIn stock)
        {
            string query = "INSERT INTO StockIn VALUES('" + stock.companyId + "','" + stock.itemId + "','" +
                           stock.reorderLavel + "','" + stock.aviableQuentity + "','" + stock.date.Date + "')";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public List<Item> GetItemWithCompany(int cmpid)
        {
            string query = "select * from Item where comId='" + cmpid + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Item> items = new List<Item>();
            while (reader.Read())
            {
                Item item = new Item();
                item.id = Convert.ToInt32(reader["id"]);
                item.itemName = reader["itemName"].ToString();
                item.reoderLavel = Convert.ToInt32(reader["reorderLabel"]);

                items.Add(item);
            }
            reader.Close();
            Connection.Close();
            return items;
        }

        public StockIn GetSignleStock(int stockid)
        {
            string query = "select * from StockIn where itemId='" + stockid + "'";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            StockIn stockIn = null;
            if (reader.HasRows)
            {
                reader.Read();
                stockIn = new StockIn();
                stockIn.aviableQuentity = Convert.ToInt32(reader["aviable_Quentity"]);
                stockIn.reorderLavel = Convert.ToInt32(reader["reorder"]);
            }
            reader.Close();
            Connection.Close();
            return stockIn;
        }

        public int UpdateQuentity(StockIn stockIn)
        {
            string query = "UPDATE StockIn SET aviable_Quentity ='" + stockIn.aviableQuentity + "' WHERE cmpId=" +
                           stockIn.companyId + "And itemId=" + stockIn.itemId;
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public bool IsExistItem(StockIn stockIn)
        {
            string query = "SELECT * FROM StockIn WHERE cmpId='" + stockIn.companyId + "'AND itemId='" + stockIn.itemId +
                           "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            Connection.Close();
            return isExist;
        }
    }
}