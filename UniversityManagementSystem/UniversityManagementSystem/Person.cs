using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityManagementSystem
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void GetDetails()
        {
            Console.WriteLine($"Name is {Name} and Age is {Age}");
        }
    }
}
