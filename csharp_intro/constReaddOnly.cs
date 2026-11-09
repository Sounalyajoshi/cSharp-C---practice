using System;
 class constReaddOnly
    {
    const double pi = 3.142;
    static void Main()
    {
        Console.WriteLine(constReaddOnly.pi);
    }


    }
class Employee
{
    readonly int employeeId;

    public Employee(int id)
    {
        employeeId = id;
    }

    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeId);

        
    }
}
class ReadOnly
{
    static void Main()
    {
        Employee emp1 = new Employee(101);
        Employee emp2 = new Employee(102);

        emp1.Display();
        emp2.Display();
    }
}

