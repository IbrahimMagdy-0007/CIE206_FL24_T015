using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Customer
{
    public class CustomerOrderConfirmationModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Role"] = "Customer";
        }
    }
}
