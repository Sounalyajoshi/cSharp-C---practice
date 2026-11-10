using System;
namespace MethodOverloadingConcept
{

    class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
    }
    class MethosOverProgram
    {
        static void Main()
        {
            Calculator obj = new Calculator();

            obj.Add(10, 20);
            obj.Add(10, 20, 30);
        }
    }
}
   