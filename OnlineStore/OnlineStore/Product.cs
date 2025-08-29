using System;
using System.Collections.Generic;

namespace OnlineStore
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual void GetProductDetails()
        {
            Console.WriteLine($"NameProduct is {Name} and PriceProduct is {Price}");
        }
    }
}
