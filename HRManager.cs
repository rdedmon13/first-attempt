using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class HRManager
    {
        private List<Employee> employees;

        public HRManager()
        {
            // Constructor 
            // initialize collection here
            //List<Employee> 

            employees = new List<Employee>();
        }

        public void Add(Employee e)
        {
            // Add new employee object to a list
            employees.Add(e);

        }

        public void Remove(string firstName)
        {
            // Remove employee object
            //var EmployeeObject = employees.SingleOrDefault(x => x.FirstName == firstName);
            //if (EmployeeObject != null)
            //employees.Remove(EmployeeObject);

            // Typically cannot remove object in collection after iteration, must use break
            // in this instance
            foreach (Employee i in employees)
            {

                if (i.FirstName == firstName)
                {
                    employees.Remove(i);
                    break;
                }
            }
        }

                




        public Employee Find(string firstName)
        {
            // Find the object that matches the first name 
            // And return the object
            foreach (Employee i in employees)
            {

                if (i.FirstName == firstName)
                {
                    return i;
                }



                else

                {
                    //return null;
                    Console.WriteLine("Employee was not found!");
                    //Console.ReadLine();
                }
            }

            return null;


        }

        public int FindPosition(string firstName)
        {
            // Find the position of the employee object that matches 
            // the first name passed in 
            // Return its position as an int

            for (int i = 0; i <= employees.Count(); i++)

            {
                if (employees[i].FirstName == firstName)

                {
                    return i;
                }

            }

            return 0;
        }

        public void Print(Employee e)
        {
            Console.WriteLine("First Name is {0}", e.FirstName);
            // Add more console.writeline
        }


        public void Print()
        {

            // Print out everything from the employee list
            // Can you iterate through the entire list and call PrintEmployee(Employee e) 
            // on each object?

        }

        public int GetCount()
        {
            // Implement this
            int NumOfEmployees = employees.Count();
            return NumOfEmployees;
        }
    }

}