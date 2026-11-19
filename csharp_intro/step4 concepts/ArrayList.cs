using System;
using System.Collections;
namespace ArrayListExample {
    public class ArrayListExample
    {
        static void Main()
        {
            ArrayList numbers = new ArrayList();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
             
            foreach(int num in numbers)
            {
               
                Console.WriteLine(num);
            }

            Console.WriteLine("----------------------");
            numbers.Remove(10);

            bool isavailable = numbers.Contains(20);
            Console.WriteLine(isavailable);


            foreach (int num in numbers)
            {

                Console.WriteLine(num);
            }


        }

    }






}