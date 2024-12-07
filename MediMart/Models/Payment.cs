using System;

namespace MediMart.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public string Method { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
