using System;

namespace MediMart.Models
{
    public class Inventory
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int StockLevel { get; set; }
        public DateTime RestockDate { get; set; }
    }
}
