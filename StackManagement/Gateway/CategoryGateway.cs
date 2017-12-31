using StackManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StackManagement.Gateway
{
    internal class CategoryGateway : Gateway
    {
        public int SaveCategory(Category category)
        {
            string query = "INSERT INTO Category VALUES('" + category.catName + "','" + category.date.Date + "','')";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public bool IsExistCatgory(Category catName)
        {
            string query = "SELECT * FROM Category WHERE catName='" + catName.catName + "'AND id<>'" + catName.id + "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            Connection.Close();
            return isExist;
        }

        public List<Category> GetAllCategories()
        {
            string query = "select * from Category";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.id = Convert.ToInt32(reader["id"]);
                category.catName = reader["catName"].ToString();

                categories.Add(category);
            }
            reader.Close();
            Connection.Close();
            return categories;
        }

        public int UpdateCategory(Category category)
        {
            string query = "UPDATE Category SET catName ='" + category.catName + "',updateDate='" + category.updateDate.Date + "' WHERE id=" + category.id;
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public List<Category> SearchCategories(string category)
        {
            string query = "SELECT * FROM Category WHERE catName Like'%"+category+"%'";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category sCategory = new Category();
                sCategory.id = (int)reader["id"];
                sCategory.catName = reader["catName"].ToString();
                
                categories.Add(sCategory);
            }
            reader.Close();
            Connection.Close();
            return categories;
        }
    }
}