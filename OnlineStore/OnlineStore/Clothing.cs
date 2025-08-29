using System;
using System.Collections.Generic;

namespace OnlineStore
{
    enum size
    {
        Small,
        Medium,
        Large,
        LargeSmall,
    }
    class Clothing : Product
    {
        public string Material { get; set; }
        public size Size { get; set; }
        public override void GetProductDetails()
        {
            base.GetProductDetails();
            Console.WriteLine($"Material=>{Material} and Size Is {Size}");
        }
    }
}
