using System;


class var_dynamic
{
    static void Main()
    {
        int age = 20;
        Console.WriteLine(age);

        string name = "janu";
        Console.WriteLine(name);




        // var keyword

        var namess = "janu";
        Console.WriteLine(namess);

        var ages = 22;
        Console.WriteLine(ages);

        var address = "3243673cross road bangaluru";
        Console.WriteLine(address);

        var height = 5.5f;
        Console.WriteLine(height);

        //dynamic

        dynamic  data = 100;
        data = 250;
        Console.WriteLine(data);
        data = "hello";
        Console.WriteLine(data);
        data = 23.4756577m;
        Console.WriteLine(data);


        dynamic data1 = 20;
        Console.WriteLine(data1);
        data = "hello hii";
        Console.WriteLine(data1);








    } 
}

