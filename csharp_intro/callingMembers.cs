using System;

static class Companys
{
    public static string companyName = "Infosys";
    public static void Display()
    {
        Console.WriteLine("Company Name: " + companyName);
    }
}
class Employe
{
    // Static field
    public static int employeId = 101;
    public string employeName = "Rahul";

 
    public static void Show()
    {
        Console.WriteLine("Employee ID: " + employeId);

    }

    // Non-static method
    public void Display()
    {
        Console.WriteLine("Employee Name: " + employeName);

        Show();
    }
}
class staticNonstaticProgram
{
    static void Main()
    {
        // 1. Calling static class members
        Console.WriteLine(Companys.companyName);
        Companys.Display();

        // 2. Calling static members of non-static class
        Console.WriteLine(Employe.employeId);
        Employe.Show();
        // 3. Creating object for non-static class
        Employe emp = new Employe();

        // Calling non-static field
        Console.WriteLine(emp.employeName);

        // Calling non-static method
        emp.Display();
    }
}
