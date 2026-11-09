using System;

namespace Company
{
    class Employee
    {
        public void Display()
        {
            Console.WriteLine("Company Employee");
        }
    }
}

namespace College
{
    class Employee
    {
        public void Display()
        {
            Console.WriteLine("College students");
        }
    }
}

class companyCollegeProgram
{
    static void Main()
    {
        Company.Employee emp1 = new Company.Employee();
        College.Employee emp2 = new College.Employee();

        emp1.Display();
        emp2.Display();
    }
}