using System;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and set first and last name
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call SayName method
            employee.SayName();

            // Use polymorphism: Create an IQuittable reference and assign Employee object
            IQuittable quittableEmployee = employee;

            // Call Quit method via the IQuittable interface
            quittableEmployee.Quit();

            // Prevent console from closing immediately
            Console.ReadLine();
        }
    }
}
