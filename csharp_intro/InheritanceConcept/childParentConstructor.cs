using System;

class ParentDetails
{
    public ParentDetails(string name, int age)
    {
        Console.WriteLine("Parent Constructor");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class ChildDetails : ParentDetails
{
    public ChildDetails(string name, int age) : base(name, age)
    {
        Console.WriteLine("Child Constructor");
    }
}

class ChildParentConstructorProgram
{
    static void Main()
    {
        ChildDetails obj = new ChildDetails("John", 25);
    }
}

class company
{
    public company(string companyName, string location)
    {
        Console.WriteLine("Parent Constructor");
        Console.WriteLine("Company Name: " + companyName);
        Console.WriteLine("Location: " + location);
    }
}

class employee : company
{
    public employee(string companyName, string location, string employeeName)
        : base(companyName, location)
    {
        Console.WriteLine("Child Constructor");
        Console.WriteLine("Employee Name: " + employeeName);
    }
}

class secondExampleProgram
{
    static void Main()
    {
        employee emp = new employee("Infosys", "Bangalore", "Rahul");
    }
}