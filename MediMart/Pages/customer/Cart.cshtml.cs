using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace MediMart.Pages.Customer
{
    public class CustomerCartModel : PageModel
    {
        public List<CartItem> CartItems { get; set; } = new();

        public void OnGet()
        {

            ViewData["Role"] = "Customer";
            ViewData["Page"] = "Cart";

            CartItems = new List<CartItem>
            {
                new CartItem { ProductName = "Product 1", Price = 10.99m, Quantity = 2 },
                new CartItem { ProductName = "Product 2", Price = 15.99m, Quantity = 1 },
            };
        }

        public class CartItem
        {
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
    }
}
