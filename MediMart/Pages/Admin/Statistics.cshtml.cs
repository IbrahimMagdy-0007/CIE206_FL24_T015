using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Admin
{
    public class StatisticsModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Role"] = "Admin";
            ViewData["Page"] = "Statistics";

        }
    }
}
