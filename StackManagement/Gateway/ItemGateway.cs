using StackManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StackManagement.Gateway
{
    internal class ItemGateway : Gateway
    {
        public int SaveItem(Item item)
        {
            string query = "INSERT INTO Item VALUES(" + item.catId + "," + item.compId + ",'" + item.itemName + "'," +
                           item.reoderLavel + ",'" + item.date.Date + "')";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public bool IsExistItem(Item item)
        {
            string query = "SELECT * FROM Item WHERE itemName='" + item.itemName + "'AND id<>'" + item.id + "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            Connection.Close();
            return isExist;
        }

        public List<Item> GetAllItems()
        {
            string query = "select * from Item";
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
    }
}