using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Admin
{
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Role"] = "Admin";
            ViewData["Page"] = "Dashboard";
        }
    }
}
