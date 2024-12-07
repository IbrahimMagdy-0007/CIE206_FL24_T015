using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Admin
{
    public class OrdersModel : PageModel
    {
        [BindProperty]
        public string OrderId { get; set; }

        [BindProperty]
        public string CustomerName { get; set; }

        [BindProperty]
        public string OrderStatus { get; set; }

        [BindProperty]
        public decimal OrderTotal { get; set; }

        public void OnGet()
        {
            ViewData["Role"] = "Admin";
            ViewData["Page"] = "Orders";

        }

        public IActionResult OnPostEditOrder()
        {
            TempData["EditSuccess"] = $"Order '{OrderId}' updated successfully.";
            return RedirectToPage();
        }
    }
}
