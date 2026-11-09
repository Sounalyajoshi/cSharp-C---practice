using System;

class String_propertices_methods
    {
    static void Main()
    {
        string name = "janusonu";
         Console.WriteLine(name.Length);
        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());
      
        Console.WriteLine(name.Contains("ja"));  

    }
    

 }
class stringPropertiesandMethods
{
    static void Main()
    {
        string name1 = " sounalya  ";
        Console.WriteLine(name1.Length);
        Console.WriteLine(name1.Trim());
        Console.WriteLine(name1.StartsWith(" "));
        Console.WriteLine(name1.EndsWith(" "));
    }
}

class StringMethods
{
    static void Main()
    {
        String name1 = "sounalya";
        Console.WriteLine(name1.Substring(0,5));
        string name3 = "janavi";
        Console.WriteLine(name3.Substring(1, 4));


        //compare()

        string name4 = "janu";
        string name5 = "janvi";

        Console.WriteLine(string.Compare(name4, name5));



        //Replace()


        string name6 = "janu kulkarni";
        Console.WriteLine(name6.Replace("janu", "janvi"));
        Console.WriteLine(name6.Replace("ja", "jaanvi"));


    }

}





