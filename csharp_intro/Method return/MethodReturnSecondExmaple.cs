using System;
namespace Employeedetails
{
    class Employee
    {
        public string EmpName { get; set; }
        public int Empsalary { get; set; }
        public string role { get; set; }


        public static Employee GetEmployee()
        {
            Employee emp = new Employee()
            {
                EmpName = "smith",
                Empsalary = 25000,
                role = "software Engineer"
            };
            return emp;

        }

    }
    class Method2Program
    {
        static void Main()
        {
            Employee e1 = Employee.GetEmployee();
            Console.WriteLine($"employee name is:{e1.EmpName} \n employee salary is:{e1.Empsalary}\n employee role is:{e1.role}");
        }
    }
}