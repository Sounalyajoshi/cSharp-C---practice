using System;
using System.Threading;

namespace valueTipeParameter
{
    class Employee
    {
        int salary = 25000;
        int bonus = 5000;

        public void DisplaySalary(int salary, int bonus)
        {
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + bonus);

            salary = 40000;
            bonus = 10000;

            Console.WriteLine("Updated salary inside method: " + salary);
            Console.WriteLine("Updated bonus inside method: " + bonus);
        }

        public void SendValues()
        {
            DisplaySalary(salary, bonus);
        }
    }

    class ValuTypeProgram
    {
        static void Main()
        {
            Employee e1 = new Employee();
            e1.SendValues();
        }
    }
    class numbers
    {
    public int marks;
        static void changeNumber(int num)
        {
            num= 100;
        }
        static void changeObject(numbers obj)
        {
            obj.marks = 1120;
        }
        static void Main()
        {
            int a = 10;
            int b;
            b = a;

            Console.WriteLine(a+" "+b);
            b = 20;
            Console.WriteLine(a+" "+b);

            numbers obj = new numbers();
            obj.marks = 250;
            numbers n1 = obj;
            Console.WriteLine(n1.marks+" "+obj.marks);

            numbers n2=new numbers();
            n2.marks = 400;
            Console.WriteLine(n2.marks);
            int num = 1200;
            numbers.changeNumber(num);
            Console.WriteLine(num);
            changeObject(obj);

            changeObject(n1);
            Console.WriteLine(n1.marks + " " + obj.marks);
            Console.WriteLine(n2.marks);
            








        }
    }

}


   




   
