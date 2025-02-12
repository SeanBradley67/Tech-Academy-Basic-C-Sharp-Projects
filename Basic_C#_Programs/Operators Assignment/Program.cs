using System;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects with the same Id
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded == operator
            if (employee1 == employee2)
            {
                Console.WriteLine("The employees have the same Id.");
            }
            else
            {
                Console.WriteLine("The employees have different Ids.");
            }

            // Instantiate two Employee objects with different Ids
            Employee employee3 = new Employee { Id = 2, FirstName = "Alice", LastName = "Johnson" };

            // Compare the two Employee objects using the overloaded == operator
            if (employee1 == employee3)
            {
                Console.WriteLine("The employees have the same Id.");
            }
            else
            {
                Console.WriteLine("The employees have different Ids.");
            }

            // Prevent the console from closing immediately
            Console.ReadLine();
        }
    }
}
