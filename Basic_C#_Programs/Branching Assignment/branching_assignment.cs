// A console-based application for getting a shipping quote for a package.
using System;

class Program
{
    static void Main()
    {
        // Display welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

        // Prompt the user to enter the package weight
        Console.Write("Please enter the package weight: ");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if the weight exceeds the limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt the user to enter the package dimensions
        Console.Write("Please enter the package width: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        // Calculate the total dimensions
        int dimensionTotal = width + height + length;

        // Check if the total dimensions exceed the limit
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the shipping quote
        int volume = width * height * length; // Calculate the volume of the package
        int quote = (volume * weight) / 100;  // Calculate the shipping cost

        // Display the shipping quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote}.00");
        Console.WriteLine("Thank you!");
    }
}
