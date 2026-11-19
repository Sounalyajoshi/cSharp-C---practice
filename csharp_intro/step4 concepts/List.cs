using System;
using System.Collections.Generic;

class ListExample
{
    static void Main()
    {
        List<string> names = new List<string>();

        names.Add("bob");
        names.Add("smith");
        names.Add("john");
        names.Add("peter");

        Console.WriteLine($"size of namelist is:{names.Count}");


        foreach(string name in names)
        {
            Console.WriteLine(name);
        }


        List<int> numbers = new List<int>() { 10, 20, 30, 40 };
        

        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("-------------------");
        numbers.Insert(2, 25);    //here after 2  numbers are shift one position
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("--------remove value-----------");

        numbers.RemoveAt(0);
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("-----update value--------------");

        numbers[3] = 50;
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }



    }
}