using System;
class ArrayExample
{
    static void Main()
    {
        int[] numbers = new int[4];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers[1]);

        int index1 = Array.IndexOf(numbers, 40);
        Console.WriteLine($"index1 valiue {index1}");

        int index3= Array.IndexOf(numbers, 20);
        Console.WriteLine($"index3 valiue {index3}");


        Console.ReadLine();
    }
}
