using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            if (Username == "admin" && Password == "admin123")
            {
                HttpContext.Session.SetString("Role", "Admin");
                return RedirectToPage("/Admin/Dashboard");
            }
            else if (Username == "customer" && Password == "customer123")
            {
                HttpContext.Session.SetString("Role", "Customer");
                return RedirectToPage("/Customer/Home");
            }
            else if (Username == "pharmacist" && Password == "pharmacist123")
            {
                HttpContext.Session.SetString("Role", "Pharmacist");
                return RedirectToPage("/Pharmacist/Dashboard");
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
                return Page();
            }
        }
    }
}
