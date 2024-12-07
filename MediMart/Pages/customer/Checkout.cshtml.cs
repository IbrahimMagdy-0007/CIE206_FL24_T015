using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Customer
{
    public class CustomerCheckoutModel : PageModel
    {
        [BindProperty]
        public string Address { get; set; }

        [BindProperty]
        public string PaymentMethod { get; set; }

        public string ConfirmationMessage { get; set; }
        public void OnGet()
        {
            ViewData["Role"] = "Customer";
            ViewData["Page"] = "Checkout";

        }

        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(Address) && !string.IsNullOrEmpty(PaymentMethod))
            {
                ConfirmationMessage = "Your order has been placed successfully!";
                return RedirectToPage("/Customer/OrderConfirmation");
            }

            ModelState.AddModelError("", "Please complete all required fields.");
            return Page();
        }
    }
}
