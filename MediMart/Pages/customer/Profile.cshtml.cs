using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace MediMart.Pages.Customer
{
    public class CustomerProfileModel : PageModel
    {
        [BindProperty]
        public ProfileData Profile { get; set; }

        public void OnGet()
        {

            ViewData["Role"] = "Customer";
            ViewData["Page"] = "Profile";

            Profile = new ProfileData
            {
                Name = "John Doe",
                Email = "johndoe@example.com",
                Phone = "+1234567890",
                DateOfBirth = new DateTime(1990, 5, 15),
                Address = "123 Main St, City, Country"
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Console.WriteLine($"Name: {Profile.Name}, Email: {Profile.Email}, Phone: {Profile.Phone}, DOB: {Profile.DateOfBirth}, Address: {Profile.Address}");
            TempData["Message"] = "Profile updated successfully!";
            return RedirectToPage("/Customer/Profile");
        }

        public class ProfileData
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Address { get; set; }
        }
    }
}
