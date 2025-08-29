using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;

namespace UniversityManagementSystem
{
    class Professor:Person
    {
        public int ProfessorId { get; set; }
        public string Subject { get; set; }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ProfessorId is {ProfessorId} and Subject is {Subject}");
            Console.ResetColor();
        }
    }
}
