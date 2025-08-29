using System;
using System.Collections.Generic;
using System.Collections;

namespace UniversityManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>()
            {
                 new Student { StudentId = 1, Name = "Ali", Age = 20, Major = "Computer Science" },
                 new Student { StudentId = 2, Name = "Sara", Age = 22, Major = "Mathematics" },
                 new Professor { ProfessorId = 100, Name = "Dr. Reza", Age = 45, Subject = "Algorithms" },
                 new Professor { ProfessorId = 101, Name = "Dr. Mina", Age = 38, Subject = "Database" }
            };
            foreach (var person in People)
            {
                person.GetDetails();
                Console.WriteLine("*********************************************************");
            }
            Console.ResetColor();
        }
    }
}
