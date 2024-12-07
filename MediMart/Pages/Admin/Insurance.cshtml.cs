using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Admin
{
    public class InsuranceModel : PageModel
    {
        [BindProperty]
        public string ProviderName { get; set; }

        [BindProperty]
        public int CoveragePercentage { get; set; }

        public string SuccessMessage { get; set; }

        public void OnGet()
        {
            ViewData["Role"] = "Admin";
            ViewData["Page"] = "Insurance";

        }

        public IActionResult OnPostSaveProvider()
        {
            SuccessMessage = $"Insurance provider '{ProviderName}' with {CoveragePercentage}% coverage saved successfully.";
            TempData["SuccessMessage"] = SuccessMessage;
            return RedirectToPage();
        }
    }
}
