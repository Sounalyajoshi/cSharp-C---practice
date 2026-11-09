using System;

static class Employees
{
    // Static fields
    public static int employeeId;
    public static string employeeName;

    // Static properties
    public static int Age { get; set; }
    public static string Department { get; set; }

    // Static constructor
    static Employees()
    {
        Console.WriteLine("Static Constructor Called");

        employeeId = 101;
        employeeName = "Rahul";
        Age = 25;
        Department = "IT";
    }

    // Static method
    public static void Display()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Employee Name: " + employeeName);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Department: " + Department);
    }
}
class StaticDemosProgram
{
    static void Main()
    {
        Console.WriteLine("Main Method Started");

        // Access static members
        Employees.Display();

        // Update static properties
        Employees.Age = 26;
        Employees.Department = "Development";

        Console.WriteLine("\nAfter Updating Details:");

        Employees.Display();
    }
}

