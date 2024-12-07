using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MediMart.Pages.Pharmacist
{
    public class PharmacistPrescriptionsModel : PageModel
    {
        public List<Prescription> Prescriptions { get; set; }

        public void OnGet()
        {
            Prescriptions = new List<Prescription>
            {
                new Prescription { Id = 1, CustomerName = "John Doe", Medication = "Medicine A" },
                new Prescription { Id = 2, CustomerName = "Jane Smith", Medication = "Medicine B" },
            };
        }

        public class Prescription
        {
            public int Id { get; set; }
            public string CustomerName { get; set; }
            public string Medication { get; set; }
        }
    }
}
