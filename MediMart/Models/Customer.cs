namespace MediMart.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int ActivityCount { get; set; }
        public int AddressID { get; set; }
        public Address Address { get; set; }
        public int InsuranceID { get; set; }
        public Insurance Insurance { get; set; }
    }
}
