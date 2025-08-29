using System;
using System.Collections.Generic;

namespace HospiTrack_
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string NationalId { get; set; }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, National ID: {NationalId}");
        }
    }
}
