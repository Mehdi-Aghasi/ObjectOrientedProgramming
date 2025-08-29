using System;
using System.Collections.Generic;

namespace OnlineStore
{
    class Electronic : Product, Idiscountable
    {
        public int WarrantyPeriod { get; set; }

        public void ApplyDiscount(double Percent)
        {
            Price -= Price * Percent / 100;
        }
        public override void GetProductDetails()
        {
            base.GetProductDetails();
            Console.WriteLine($"WarrantyPeriod:{WarrantyPeriod}");
        }
    }
}
