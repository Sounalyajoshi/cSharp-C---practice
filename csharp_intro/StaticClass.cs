
using System;

static class Department

{
    public static string name = "cse";

    public static string Location { get; set; }     // static properties

    static Department()
    {
        Location = "bangaluru";
        Console.WriteLine("static constructor execuited");
    }

}
class CheckDepartment
{
    static void Main()
    {
       Console.WriteLine( Department.name);
        Console.WriteLine(Department.Location);
        
    }
}


static class Family
{

    public static string famName = "kulkarni";      //static field
    public static  int age = 1;

     static Family()                                   // static constructor
    {
        Console.WriteLine("static constructor get ececuted");
        age = 12;
    }

    class FamDetails
    {
        static void Main()
        {
            Console.WriteLine(Family.age);
        }
    }
}
