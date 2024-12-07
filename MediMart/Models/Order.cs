using System.Collections.Generic;

namespace MediMart.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string OrderName { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public int AddressID { get; set; }
        public Address Address { get; set; }
        public int PaymentID { get; set; }
        public Payment Payment { get; set; }
        public List<Product> Products { get; set; }
    }
}
