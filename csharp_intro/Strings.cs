using System;


     class Strings
    {

    static void Main()
    {
        string name1 = "janu";
        Console.WriteLine(name1);

        

        string FirstName = "janu";
        string LastName = "kulkarni";
        string FullName = FirstName + " " + LastName;
        Console.WriteLine(FullName);


        // string methods
        string name = "janu kulkarni";
        Console.WriteLine(name.Length);
        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());
        Console.WriteLine(name.Replace("janu", "Janu"));
        Console.WriteLine(name.Trim());
        Console.WriteLine(name.StartsWith("ja"));

        Console.WriteLine(name.Substring(0, 6));

        string nam = "  janu  ";
        Console.WriteLine(nam.Substring(1,3));
        Console.WriteLine(nam.Trim());















    }



    }

