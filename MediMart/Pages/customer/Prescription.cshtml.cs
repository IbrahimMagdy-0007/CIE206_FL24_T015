using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace MediMart.Pages.Customer
{
    public class CustomerPrescriptionModel : PageModel
    {
        public List<Prescription> Prescriptions { get; set; } = new();

        public void OnGet()
        {
            ViewData["Role"] = "Customer";
            ViewData["Page"] = "Prescription";

            Prescriptions = new List<Prescription>
            {
                new Prescription { FileName = "Prescription1.pdf", UploadDate = DateTime.Now.AddDays(-2) },
                new Prescription { FileName = "Prescription2.pdf", UploadDate = DateTime.Now.AddDays(-5) }
            };
        }

        public IActionResult OnPost()
        {
            var uploadedFile = Request.Form.Files["PrescriptionFile"];
            var notes = Request.Form["Notes"];

            if (uploadedFile != null && uploadedFile.Length > 0)
            {
                Prescriptions.Add(new Prescription
                {
                    FileName = uploadedFile.FileName,
                    UploadDate = DateTime.Now
                });

                TempData["SuccessMessage"] = "Prescription uploaded successfully.";
                return RedirectToPage();
            }

            TempData["ErrorMessage"] = "Please upload a valid file.";
            return Page();
        }

        public class Prescription
        {
            public string FileName { get; set; }
            public DateTime UploadDate { get; set; }
        }
    }
}
