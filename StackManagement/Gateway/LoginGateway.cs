using StackManagement.Model;
using System.Data.SqlClient;

namespace StackManagement.Gateway
{
    internal class LoginGateway : Gateway
    {
        public bool IsExistItem(Login login)
        {
            string query = "SELECT * FROM Login WHERE userName='" + login.userName + "'AND password='" + login.password +
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