using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Admin
{
    public class ProductsModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Role"] = "Admin";
            ViewData["Page"] = "Products";

        }
    }
}
