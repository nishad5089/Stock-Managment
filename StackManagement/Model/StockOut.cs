using System;

namespace StackManagement.Model
{
    internal class StockOut
    {
        public int id { get; set; }
        public int companyId { get; set; }
        public int itemId { get; set; }
        public int aviableQuentity = 0;
        public int takenQuentity { get; set; }

        public string losed = "No";
        public string damaged = "No";
        public string sell = "No";

        public DateTime insertDate { get; set; }
        public DateTime updateDate { get; set; } 
    }
}