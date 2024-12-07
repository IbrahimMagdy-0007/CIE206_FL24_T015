using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MediMart.Pages.Customer
{
    public class CustomerStoreModel : PageModel
    {
        public List<Product> Products { get; set; }
        public List<string> Categories { get; set; }

        public void OnGet()
        {
            ViewData["Role"] = "Customer";
            ViewData["Page"] = "Store";

            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 29.99m, ImageUrl = "/images/product1.jpg" },
                new Product { Id = 2, Name = "Product 2", Price = 59.99m, ImageUrl = "/images/product2.jpg" },
                new Product { Id = 3, Name = "Product 3", Price = 19.99m, ImageUrl = "/images/product3.jpg" },
                new Product { Id = 4, Name = "Product 4", Price = 99.99m, ImageUrl = "/images/product4.jpg" },
            };

            Categories = new List<string> { "Category 1", "Category 2", "Category 3" };
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string ImageUrl { get; set; }
        }
    }
}
