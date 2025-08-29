using System;
using System.Collections.Generic;

namespace UniversityManagementSystem
{
    class Student:Person
    {
        public int StudentId { get; set; }
        public string Major { get; set; }
        public override void GetDetails()
        {

            base.GetDetails();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"StudentId is {StudentId} and Major is {Major}");
            Console.ResetColor();
        }
    }
}
