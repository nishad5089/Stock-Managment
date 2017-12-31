using StackManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StackManagement.Gateway
{
    internal class CompanyGateway : Gateway
    {
        public int SaveCompany(Company company)
        {
            string query = "INSERT INTO Company VALUES('" + company.name + "','" + company.date.Date + "')";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public bool IsExistCompanyName(string companyName)
        {
            string query = "SELECT * FROM Company WHERE comName='" + companyName + "'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            Connection.Close();
            return isExist;
        }

        public List<Company> GetAllCompanies()
        {
            string query = "select * from Company";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Company> companies = new List<Company>();
            while (reader.Read())
            {
                Company company = new Company();
                company.id = Convert.ToInt32(reader["id"]);
                company.name = reader["comName"].ToString();

                companies.Add(company);
            }
            reader.Close();
            Connection.Close();
            return companies;
        }
        public List<Company> SearchCompany(string company)
        {
            string query = "SELECT * FROM Company WHERE comName Like'%" + company + "%'";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Company> companies = new List<Company>();
            while (reader.Read())
            {
                Company sCompany = new Company();
                sCompany.id = (int)reader["id"];
                sCompany.name = reader["comName"].ToString();

                companies.Add(sCompany);
            }
            reader.Close();
            Connection.Close();
            return companies;
        }
    }
}