using System.Data.SqlClient;

namespace StackManagement.Gateway
{
    internal class Gateway
    {
        private string connectingstring = @"Data Source=DESKTOP-D7H2LP0\SQLExpress;Initial Catalog=StockManagement;Integrated Security=True";
        public SqlConnection Connection { get; set; }
        public SqlDataReader Reader { get; set; }
        public SqlCommand Command { get; set; }
        public string Query { get; set; }

        public Gateway()
        {
            Connection = new SqlConnection(connectingstring);
        }
    }
}