using System;

namespace StackManagement.Model
{
    internal class Item
    {
        public int id { get; set; }
        public int catId { get; set; }
        public int compId { get; set; }
        public string itemName { get; set; }
        public int reoderLavel { get; set; }
        public DateTime date { get; set; }
    }
}