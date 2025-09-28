using System; // Importing the System namespace to use basic functionalities like Console

// Define a custom class named 'MathOperations'
public class MathOperations
{
    // Define a method that takes two integers as parameters
    public void DoMath(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first number (e.g., multiply it by 7)
        int result = firstNumber * 7;

        // Display the result of the math operation
        Console.WriteLine("Result of operation on first number: " + result);

        // Display the second number
        Console.WriteLine("Second number is: " + secondNumber);
    }
}

// The main class where program execution starts
class Program
{
    // The entry point of the console application
    static void Main(string[] args)
    {
        // Create an instance (object) of the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call the DoMath method using positional arguments
        // Here, 5 is the first number and 10 is the second number
        mathOps.DoMath(6, 12);

        // Call the DoMath method using named arguments
        // The order of parameters doesn't matter when using named arguments
        mathOps.DoMath(secondNumber: 20, firstNumber: 8);

        // Wait for user input to keep the console window open (optional)
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
