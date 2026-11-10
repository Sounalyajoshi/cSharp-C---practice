using System;
namespace Overrideconcept
{
    abstract class Employee
    {
        public abstract void CalculateSalary();
    }
    class PermanentEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Permanent Employee Salary: 30000");
        }
    }
    class ContractEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Contract Employee Salary: 15000");
        }
    }

   
    class Override2Program
    {
        static void Main()
        {
            PermanentEmployee emp1 = new PermanentEmployee();
            ContractEmployee emp2 = new ContractEmployee();

            emp1.CalculateSalary();
            emp2.CalculateSalary();
        }
    }

}
