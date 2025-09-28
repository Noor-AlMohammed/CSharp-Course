using System; // Required for Console operations

// Define the IQuittable interface with one method: Quit()
public interface IQuittable
{
    // Method signature for Quit (no return value)
    void Quit();
}

// Define the Employee class that implements IQuittable
public class Employee : IQuittable
{
    // Property for employee's first name
    public string FirstName { get; set; }

    // Property for employee's last name
    public string LastName { get; set; }

    // Implement the Quit() method from the IQuittable interface
    public void Quit()
    {
        // Display a message when an employee quits
        Console.WriteLine($"{FirstName} {LastName} has resigned from the company.");
    }
}

// Program class contains the Main method - entry point of the console app
class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object and assign values to its properties
        Employee emp = new Employee
        {
            FirstName = "Noor",
            LastName = "AlMohammed"
        };

        // Demonstrate polymorphism by using an interface type variable
        IQuittable quittableEmployee = emp;

        // Call the Quit() method on the IQuittable object
        // Even though the object is of type IQuittable, it uses Employee's implementation
        quittableEmployee.Quit();

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
