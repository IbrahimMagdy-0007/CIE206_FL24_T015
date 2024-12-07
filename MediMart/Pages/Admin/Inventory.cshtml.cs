using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Admin
{
    public class InventoryModel : PageModel
    {
        [BindProperty]
        public string ProductName { get; set; }

        [BindProperty]
        public int StockLevel { get; set; }

        [BindProperty]
        public string OrderProductName { get; set; }

        [BindProperty]
        public int OrderQuantity { get; set; }

        [BindProperty]
        public string Supplier { get; set; }

        public string OrderConfirmationMessage { get; set; }

        public void OnGet()
        {
            ViewData["Role"] = "Admin";
            ViewData["Page"] = "Inventory";

        }

        public IActionResult OnPostOrderProduct()
        {
            OrderConfirmationMessage = $"Order placed for {OrderQuantity} units of '{OrderProductName}' from supplier '{Supplier}'.";

            TempData["OrderSuccess"] = OrderConfirmationMessage;
            return RedirectToPage();
        }
    }
}
