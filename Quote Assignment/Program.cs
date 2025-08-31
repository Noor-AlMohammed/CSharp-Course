using System;

class Program
{
    static void Main()
    {
        // Greet the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Input weight
        Console.Write("Enter weight: ");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Input dimensions
        Console.Write("Enter width: ");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter height: ");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter length: ");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Check size constraint
        if ((width + height + length) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate and display shipping cost
        decimal cost = (width * height * length * weight) / 100;
        Console.WriteLine($"Your estimated total for shipping this package is: ${cost:0.00}");
        Console.WriteLine("Thank you!");
    }
}
