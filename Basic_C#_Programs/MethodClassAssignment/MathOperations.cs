using System;


namespace MethodClassAssignment
{
    class MathOperations
    {
        // Method that takes two integers as parameters
        // It performs a math operation on the first integer and displays the second integer
        public void PerformOperation(int num1, int num2)
        {
            // Perform a simple math operation: multiply the first integer by 2
            int result = num1 * 2;

            // Display the result of the math operation
            Console.WriteLine("The result of multiplying the first number by 2 is: " + result);

            // Display the second integer as is
            Console.WriteLine("The second number is: " + num2);
        }
    }
}
