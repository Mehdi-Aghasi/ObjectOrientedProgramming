using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                  new Electronic { Name = "Laptop", Price = 1500, WarrantyPeriod = 24 },
                  new Electronic { Name = "Smartphone", Price = 800, WarrantyPeriod = 12 },
                  new Electronic { Name = "Headphones", Price = 200, WarrantyPeriod = 6 },
                  new Clothing { Name = "T-Shirt", Price = 40, Material = "Cotton", Size = size.Medium },
                  new Clothing { Name = "Jacket", Price = 120, Material = "Leather", Size = size.Large },
                  new Clothing { Name = "Jeans", Price = 60, Material = "Denim", Size = size.Small }
            };
            foreach (var product in products)
            {
                product.GetProductDetails();
                if (product is Idiscountable discountable)
                {
                    discountable.ApplyDiscount(10);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("After discount:");
                    product.GetProductDetails();
                    Console.ResetColor();
                }
                Console.WriteLine("------------------------");
            }
        }
    }
}
