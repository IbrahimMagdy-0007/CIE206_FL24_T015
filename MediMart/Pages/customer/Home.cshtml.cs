using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MediMart.Pages.Customer
{
    public class CustomerHomeModel : PageModel
    {
        public List<Product> PopularProducts { get; set; } = new();

        public void OnGet()
        {
            ViewData["CustomerName"] = "John Doe";
            ViewData["Page"] = "Home";


            PopularProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10.99m },
                new Product { Id = 2, Name = "Product 2", Price = 15.99m },
                new Product { Id = 3, Name = "Product 3", Price = 12.99m },
                new Product { Id = 4, Name = "Product 4", Price = 8.99m },
            };
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
