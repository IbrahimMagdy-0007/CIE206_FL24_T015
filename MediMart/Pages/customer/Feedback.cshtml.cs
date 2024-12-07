using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediMart.Pages.Customer
{
    public class CustomerFeedbackModel : PageModel
    {
        [BindProperty]
        public string Subject { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public string SuccessMessage { get; set; }
        public void OnGet()
        {
            ViewData["Role"] = "Customer";
            ViewData["Page"] = "Feedback";

        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(Subject) && !string.IsNullOrEmpty(Message))
            {
                SuccessMessage = "Thank you for your feedback!";
            }
            else
            {
                ModelState.AddModelError("", "Both Subject and Message are required.");
            }
        }
    }
}
