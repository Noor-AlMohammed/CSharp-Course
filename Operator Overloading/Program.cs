using System; // Provides basic functionality like Console class

// Define the Employee class
public class Employee
{
    // Auto-implemented properties for Id, FirstName, and LastName
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare two Employee objects by their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both are null, or both are same instance, return true
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If either is null, but not both, return false
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare by Id
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator (must be paired with "==")
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // It's recommended to override Equals when overloading ==
    public override bool Equals(object obj)
    {
        var other = obj as Employee;
        if (other == null)
            return false;

        return this.Id == other.Id;
    }

    // Also override GetHashCode when Equals is overridden
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

// Main program class
class Program
{
    // Main method: entry point of the application
    static void Main(string[] args)
    {
        // Create the first Employee object and assign values
        Employee emp1 = new Employee
        {
            Id = 101,
            FirstName = "Noor",
            LastName = "AlMohammed"
        };

        // Create the second Employee object and assign values
        Employee emp2 = new Employee
        {
            Id = 102, // Change this to 101 later
            FirstName = "Will",
            LastName = "Smith"
        };

        // Compare the two Employee objects using the overloaded "=="
        if (emp1 == emp2)
        {
            Console.WriteLine("Both employees are considered equal (same Id).");
        }
        else
        {
            Console.WriteLine("Employees are not equal (different Ids).");
        }

        // Show usage of "!=" operator as well
        if (emp1 != emp2)
        {
            Console.WriteLine("Confirmed: The employees are not the same.");
        }
        else
        {
            Console.WriteLine("Confirmed: The employees are equal.");
        }

        // Keep the console window open until a key is pressed
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
