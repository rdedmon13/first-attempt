using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{

    class Program
    {

        static void DisplayMenu()
        {
            Console.WriteLine("\nWelcome!");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Change Employee Info");
            Console.WriteLine("4. Exit Application \n");
            Console.Write("Input here: ");
        }

        static void Main(string[] args)
        {
            HRManager HR = new HRManager();
            Employee e = new Employee();
            int menuChoice = 0;

            DisplayMenu();
            menuChoice = int.Parse(Console.ReadLine());

            while (menuChoice != 5)

            {
                switch (menuChoice)
                {

                    case 1:

                        // Add new employee
                        //Employee e = new Employee();
                        HR.Add(e);
                        Console.WriteLine("\nEmployee {0} has been added to the list! \n", HR.GetCount());
                        Console.Write("What would you like employee name to be? ");
                        e.FirstName = Console.ReadLine();
                        Console.WriteLine("\nOk! Employee {0} name set to {1} \n ", HR.GetCount(), e.FirstName);
                        break;

                    case 2:

                        // Remove employee
                        Console.Write("Which employee would you like to remove? ");
                        var employeeName = Console.ReadLine();

                        if (employeeName == e.FirstName)
                        {
                            Console.Write("Are you sure you want to remove {0}? ", employeeName);
                            var areYouSure = Console.ReadLine();

                            if (areYouSure.StartsWith("y"))
                            {

                                HR.Remove(employeeName);

                            }

                        }

                        else

                        {
                            Console.WriteLine("That employee was not found!");
                            break;
                        }

                        Console.WriteLine("{0} removed!", employeeName);

                        break;

                    case 3:

                        // Insert some code here
                        Console.WriteLine("What employee are we changing information for? ");
                        var whichEmployee = Console.ReadLine();

                        var employeeFound = HR.Find(whichEmployee);
                        if (employeeFound != null)
                        {
                            Console.WriteLine("Employee found!");
                        }

                        else if (employeeFound == null)

                        {
                            Console.WriteLine("Employee not found!");
                        }
          
                        Console.WriteLine("\nWhat information would you like to change? ");
                        Console.Write("You can choose from the following: ");
                        Console.WriteLine("First Name, Last Name, Department Name");
                        Console.WriteLine("Input here: ");
                        var whatToChange = Console.ReadLine();

                        if (whatToChange == "First Name")
                        {
                            Console.Write("What would you like First Name to be? ");
                            var changeFirstName = Console.ReadLine();
                            e.FirstName = changeFirstName;
                            Console.WriteLine("First name has been changed to {0}", changeFirstName);
                        }

                        //else if ()
                        //{ }

                        //else if ()
                        //{ }

                        else
                         {
                            Console.WriteLine("That is not a valid option!");
                            continue;
                        }


                        break;

                    case 4:

                        // Insert some code here
                        Console.WriteLine("\nExiting Application");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("Please choose a valid selection");
                        break;


                }

                Console.Write("\nWould you like to return to Main Menu? ");

                var returntoMenu = Console.ReadLine();

                if (returntoMenu.StartsWith("y"))
                {

                    DisplayMenu();
                    menuChoice = int.Parse(Console.ReadLine());
                    continue;
                }

                else
                {
                    DisplayMenu();
                    menuChoice = int.Parse(Console.ReadLine());
                    continue;
                }

            }
        }
    }
}


// Employee employee2 = (new Employee
// {
//FirstName = "Sam",
// LastName = "hello",
// Age = 53,
// DateOfBirth = Convert.ToDateTime("04/13/1978"),
// DepartmentName = "I/S"
// });



// Add another employee
// HR.Add(employee2);

// Remove the first employee
// HR.Remove("Alice");

// Utilize print method
// int NumOfEmployees = HR.GetCount();
//Console.WriteLine("You have {0} number of employees", NumOfEmployees);

// We should have just 1 employee

// Print count

// Print lone employee



// Find employee by first name
// Employee AliceIsFound = HR.Find("bob");
//try
// {
// Console.WriteLine("You found {0}", AliceIsFound.FirstName);
// }

//catch (NullReferenceException)
//{
// Console.WriteLine("NullReferenceException");
//}


//var a = HR.FindPosition("Alice");
//Console.WriteLine("Position of employee is at index {0}", a);




// Use the first name of the employee that is left

// Play w/ other methods that are in the HRManager class