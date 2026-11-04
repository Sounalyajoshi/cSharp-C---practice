using System;


    class datatypes
{
    static void Main()
    {
        //it accepts only 0 to 255 numbers only
        byte age = 25;
        Console.WriteLine(age);

        byte temprature = 255;
        Console.WriteLine("temprature is" + temprature);

        //short
        short num = -12345;
        Console.WriteLine(num);
        short a = 100;
        short b = -200;
        short c = 30000;
        Console.WriteLine(a + "\n" + b + "\n" + c);
        Console.WriteLine("-------------------------");

        //int --- store whole numbers
        int id = 25;
        int salary = 20000;
        int marks = 80;
        Console.WriteLine(id);
        Console.WriteLine(salary);
        Console.WriteLine(marks);

        Console.WriteLine("-------------------------");


        //uint

        uint mobilenum = 14354;
        uint amount = 10000006;
        Console.WriteLine(mobilenum);
        Console.WriteLine(amount);
        Console.WriteLine("-------------------------");

        //long

        long population = 23454667588;
        long distance = 3547788;
        long amounts = 2000000000;
        Console.WriteLine(population);
        Console.WriteLine(distance);
        Console.WriteLine(amounts);
        Console.WriteLine("-------------------------");


        //ulong
        ulong x = 1000000;
        ulong y = 68979797576;
        Console.WriteLine(x + "\n" + y);
        Console.WriteLine("-------------------------");


        // short

        short a1 = 100;
        short a2 = -200;
        short a3 = 300;
        Console.WriteLine(a1 + "\n" + a2 + "\n" + a3);
        Console.WriteLine("-------------------------");

        //float
        float price = 10.45f;
        float height = 5.4f;
        Console.WriteLine(price);
        Console.WriteLine(height);

        //double
        double x1 = 99.98;
        double x2 = 123.456;
        double x3 = 45.38;
        Console.WriteLine(x1);
        Console.WriteLine(x2);
        Console.WriteLine(x3);

        // these datatypes are having suffixes.
        long age1 = 24547487565788l;
        float numsd = 258.87546477f;
        decimal gds = 424666473648.00m;
        Console.WriteLine(age1);
        Console.WriteLine(numsd);
        Console.WriteLine(gds);





        Console.WriteLine($"the minimum value is:{byte.MinValue} and {byte.MaxValue}");
        Console.WriteLine($"the min value is:{short.MinValue} and max value is:{short.MaxValue}");





















    }
}

