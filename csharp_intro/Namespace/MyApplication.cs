using System;

namespace MyApplication
{
    class Employee
    {
        public void Display()
        {
            Console.WriteLine("Welcome to C# Namespace");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Display();
        }
    }
}

namespace MyCalculator
{
    class Calculator
    {
        public void Add()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Addition = " + (a + b));
        }
    }
}

class CalculatorProgram
{
    static void Main()
    {
        MyCalculator.Calculator obj = new MyCalculator.Calculator();

        obj.Add();
    }
}