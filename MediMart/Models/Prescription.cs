using System;

namespace MediMart.Models
{
    public class Prescription
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int PharmacistID { get; set; }
        public Pharmacist Pharmacist { get; set; }
        public string DoctorName { get; set; }
        public DateTime Date { get; set; }
    }
}
