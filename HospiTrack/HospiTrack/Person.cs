using System;
using System.Collections.Generic;
using System.Net.Cache;

namespace HospiTrack
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationalld { get; set; }
        public void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, National ID: {Nationalld}");
        }
    }
}
