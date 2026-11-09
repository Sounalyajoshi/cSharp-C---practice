using System;

     class Explicit
    {
      static void Main()
    {
        double height = 5.6;
        int check = (int)height;
        Console.WriteLine(check);

        double a=234.56;
        short b = (short)a;
        Console.WriteLine(b);


        double salary = 250000.55;
        int finalSalary = (int)salary;
        Console.WriteLine(finalSalary);


        double number = 45.89;
        int results = (int)number;
        Console.WriteLine(results);

        string num = "50";
        int result = Convert.ToInt32(num);
        Console.WriteLine(result);


        string nums = "2334546";
        double b1 = Convert.ToInt32(nums);

        Console.WriteLine(b1);

        int age = 25;
        string result1 = age.ToString();
        Console.WriteLine(result1);




        Console.WriteLine("enter the name");
        string name = Console.ReadLine();
        Console.WriteLine(name);


        int n = 10;
        string m = n.ToString();
        Console.WriteLine(m + 20);



        Student s1 = new Student();
        s1.name = "arjun";
        Student s2 = s1;
        s2.name = "rahul";
        Console.WriteLine(s1.name);
        Console.WriteLine(s2.name);


        int x = 10;
        int y = x;
        y = 200;
        Console.WriteLine(y);
        Console.WriteLine(x);





    }
}

