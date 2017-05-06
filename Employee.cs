using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        // Change this to have only a getter and not a setter
        // Tip: remove set
        // Set the getter to the difference between today's date and DOB
        // Can look up how to set up only a getter in C#
        public int Age { get; set; }

        // Add more properties relevant to an employee
        // things that would define an employee
        // ...

        // This will evolve overtime to be a separate class
        public string DepartmentName { get; set; }

    }
}
