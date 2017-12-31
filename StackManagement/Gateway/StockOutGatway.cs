using StackManagement.Model;
using System;
using System.Data.SqlClient;

namespace StackManagement.Gateway
{
    internal class StockOutGatway : Gateway
    {
        public int StockSave(StockOut stockout)
        {
            string query = "INSERT INTO StockOut(cmp_id,item_id,taken_quentity,sell_item,damage_item,lost_item,insert_date) VALUES('" + stockout.companyId + "','" + stockout.itemId + "','" + stockout.takenQuentity + "','" + stockout.sell + "','" + stockout.damaged + "','" + stockout.losed + "','" + stockout.insertDate.Date + "')";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public bool IsSelledOut(StockOut stockOut)
        {
            string query = "SELECT * FROM StockOut WHERE cmp_id='" + stockOut.companyId + "'AND item_id='" + stockOut.itemId +
                           "' AND sell_item='Yes'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            Connection.Close();
            return isExist;
        }

        public bool IsDemagedOut(StockOut stockOut)
        {
            string query = "SELECT * FROM StockOut WHERE cmp_id='" + stockOut.companyId + "'AND item_id='" + stockOut.itemId +
                           "' AND damage_item='Yes'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            Connection.Close();
            return isExist;
        }

        public bool IsLostOut(StockOut stockOut)
        {
            string query = "SELECT * FROM StockOut WHERE cmp_id='" + stockOut.companyId + "'AND item_id='" + stockOut.itemId +
                           "' AND lost_item='Yes'";
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = Command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            Connection.Close();
            return isExist;
        }

        public int UpdateTakenQuentity(StockOut stockOut)
        {
            string query = "UPDATE StockOut SET taken_quentity ='" + stockOut.takenQuentity + "' WHERE cmp_id=" +
                           stockOut.companyId + "And item_id=" + stockOut.itemId;
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }

        public StockOut GetTekenQuentity(StockOut stockOut)
        {
            string query = "SELECT * FROM StockOut WHERE cmp_id='" + stockOut.companyId + "'AND item_id='" + stockOut.itemId +
                           "'";
            SqlCommand command = new SqlCommand(query, Connection);
            Connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            StockOut stockout = null;
            if (reader.HasRows)
            {
                reader.Read();
                stockout = new StockOut();
                stockout.id = Convert.ToInt32(reader["id"]);
                stockout.takenQuentity = Convert.ToInt32(reader["taken_quentity"]);
            }

            reader.Close();
            Connection.Close();
            return stockout;
        }

        public int UpdateAviableQuentity(StockOut stockOut)
        {
            string query = "UPDATE StockIn SET aviable_Quentity ='" + stockOut.aviableQuentity + "' WHERE cmpId=" +
                           stockOut.companyId + " And itemId=" + stockOut.itemId;
            Command = new SqlCommand(query, Connection);
            Connection.Open();
            int rowAffect = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffect;
        }
    }
}