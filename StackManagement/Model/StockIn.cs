using System;

namespace StackManagement.Model
{
    internal class StockIn
    {
        public int id { get; set; }
        public int companyId { get; set; }
        public int itemId { get; set; }

        public int reorderLavel { get; set; }
        public int aviableQuentity = 0;
        public int stockInQuentity { get; set; }
        public DateTime date { get; set; }
    }
}