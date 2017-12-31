using StackManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StackManagement.Gateway
{
    internal class Serch_View_Gateway : Gateway
    {
        public List<Serch_View> GetAllRelatedItem()
        {
            string query = "select * from Serch_view";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Serch_View> itemList = new List<Serch_View>();
            while (reader.Read())
            {
                Serch_View listOfItem = new Serch_View();
                listOfItem.companyName = reader["comName"].ToString();
                if (string.IsNullOrEmpty(reader["catName"].ToString()))
                {
                    listOfItem.catName = "No Category";
                }
                else
                {
                    listOfItem.catName = reader["catName"].ToString();
                }
                if (string.IsNullOrEmpty(reader["itemName"].ToString()))
                {
                    listOfItem.itemName = "No Item";
                }
                else
                {
                    listOfItem.itemName = reader["itemName"].ToString();
                }

                if (String.IsNullOrEmpty(reader["aviable_Quentity"].ToString()))
                {
                    listOfItem.aviableQuantity = 0;
                }
                else
                {
                    listOfItem.aviableQuantity = Convert.ToInt32(reader["aviable_Quentity"].ToString());
                }
                if (string.IsNullOrEmpty(reader["reorder"].ToString()))
                {
                    listOfItem.reorderLabel = 0;
                }
                else
                {
                    listOfItem.reorderLabel = Convert.ToInt32(reader["reorder"]);
                }

                itemList.Add(listOfItem);
            }
            reader.Close();
            Connection.Close();
            return itemList;
        }

        public List<Serch_View> GetWithCategory(Serch_View serchView)
        {
            string query = "select * from Serch_view where categroyID=" + serchView.catId;
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Serch_View> itemList = new List<Serch_View>();
            while (reader.Read())
            {
                Serch_View listOfItem = new Serch_View();
                //listOfItem.id = Convert.ToInt32(reader["id"]);
                listOfItem.companyName = reader["comName"].ToString();
                if (string.IsNullOrEmpty(reader["catName"].ToString()))
                {
                    listOfItem.catName = "No Category";
                }
                else
                {
                    listOfItem.catName = reader["catName"].ToString();
                }
                if (string.IsNullOrEmpty(reader["itemName"].ToString()))
                {
                    listOfItem.itemName = "No Item";
                }
                else
                {
                    listOfItem.itemName = reader["itemName"].ToString();
                }

                if (String.IsNullOrEmpty(reader["aviable_Quentity"].ToString()))
                {
                    listOfItem.aviableQuantity = 0;
                }
                else
                {
                    listOfItem.aviableQuantity = Convert.ToInt32(reader["aviable_Quentity"].ToString());
                }
                if (string.IsNullOrEmpty(reader["reorder"].ToString()))
                {
                    listOfItem.reorderLabel = 0;
                }
                else
                {
                    listOfItem.reorderLabel = Convert.ToInt32(reader["reorder"]);
                }

                itemList.Add(listOfItem);
            }

            reader.Close();
            Connection.Close();
            return itemList;
        }

        public List<Serch_View> GetWithCompany(Serch_View serchView)
        {
            string query = "select * from Serch_view where companyId=" + serchView.compId;
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Serch_View> itemList = new List<Serch_View>();
            while (reader.Read())
            {
                Serch_View listOfItem = new Serch_View();
                //listOfItem.id = Convert.ToInt32(reader["id"]);
                listOfItem.companyName = reader["comName"].ToString();
                if (string.IsNullOrEmpty(reader["catName"].ToString()))
                {
                    listOfItem.catName = "No Category";
                }
                else
                {
                    listOfItem.catName = reader["catName"].ToString();
                }
                if (string.IsNullOrEmpty(reader["itemName"].ToString()))
                {
                    listOfItem.itemName = "No Item";
                }
                else
                {
                    listOfItem.itemName = reader["itemName"].ToString();
                }

                if (String.IsNullOrEmpty(reader["aviable_Quentity"].ToString()))
                {
                    listOfItem.aviableQuantity = 0;
                }
                else
                {
                    listOfItem.aviableQuantity = Convert.ToInt32(reader["aviable_Quentity"].ToString());
                }
                if (string.IsNullOrEmpty(reader["reorder"].ToString()))
                {
                    listOfItem.reorderLabel = 0;
                }
                else
                {
                    listOfItem.reorderLabel = Convert.ToInt32(reader["reorder"]);
                }

                itemList.Add(listOfItem);
            }
            reader.Close();
            Connection.Close();
            return itemList;
        }

        public List<Serch_View> GetWithCompandCat(Serch_View serchView)
        {
            string query = "select * from Serch_view where categroyID=" + serchView.catId + " AND companyId=" + serchView.compId;
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Serch_View> itemList = new List<Serch_View>();
            while (reader.Read())
            {
                Serch_View listOfItem = new Serch_View();
                //listOfItem.id = Convert.ToInt32(reader["id"]);
                listOfItem.companyName = reader["comName"].ToString();
                if (string.IsNullOrEmpty(reader["catName"].ToString()))
                {
                    listOfItem.catName = "No Category";
                }
                else
                {
                    listOfItem.catName = reader["catName"].ToString();
                }
                if (string.IsNullOrEmpty(reader["itemName"].ToString()))
                {
                    listOfItem.itemName = "No Item";
                }
                else
                {
                    listOfItem.itemName = reader["itemName"].ToString();
                }

                if (String.IsNullOrEmpty(reader["aviable_Quentity"].ToString()))
                {
                    listOfItem.aviableQuantity = 0;
                }
                else
                {
                    listOfItem.aviableQuantity = Convert.ToInt32(reader["aviable_Quentity"].ToString());
                }
                if (string.IsNullOrEmpty(reader["reorder"].ToString()))
                {
                    listOfItem.reorderLabel = 0;
                }
                else
                {
                    listOfItem.reorderLabel = Convert.ToInt32(reader["reorder"]);
                }

                itemList.Add(listOfItem);
            }
            reader.Close();
            Connection.Close();
            return itemList;
        }
    }
}