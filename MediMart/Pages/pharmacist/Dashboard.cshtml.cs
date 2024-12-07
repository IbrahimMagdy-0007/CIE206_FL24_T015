using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Pharmacist
{
    public class PharmacistDashboardModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Role"] = "Pharmacist";
            ViewData["Page"] = "Dashboard";

        }
    }
}
