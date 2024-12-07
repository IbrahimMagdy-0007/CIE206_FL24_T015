using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Admin
{
    public class UsersModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Role"] = "Admin";
            ViewData["Page"] = "Users";

        }
    }
}
