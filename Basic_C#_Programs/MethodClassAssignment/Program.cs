using System;


namespace MethodClassAssignment
{
    // Main entry point of the program
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the method by passing in two numbers directly
            mathOperations.PerformOperation(5, 10);

            // Call the method again, this time specifying parameters by name
            mathOperations.PerformOperation(num1: 7, num2: 15);

            // Wait for user input before closing the console window (so user can see the output)
            Console.ReadLine();
        }
    }
}
