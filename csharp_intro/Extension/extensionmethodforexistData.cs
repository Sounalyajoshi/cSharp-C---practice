using System;
namespace extensionMethods
{
    public static class IntegerExtension
    {
        public static int Square(this int number)
        {
            return number * number;
        }
    }
    public class ExtensionMethod1
    {
        static void Main()
        {
            int num = 5;
            int result = num.Square();

            Console.WriteLine("square :" + result);
        }
    }

   static class Calculation
    {
        public static int cube(this int num)
        {
            return num * num * num;
        }
    }

    class ClaculationProgram
    {
        static void Main()
        {
            int num = 2;

            Console.WriteLine(num.cube());
        }
    }


}