using System;

class GreetStudent
{
    public string name { get; set; }
    public int age { get; set; }
    public double height { get; set; }
    public double marks { get; set; }


    public (string name, int age, double height, double marks) studentdetails()
    {
        return ("smith", 22, 54.50, 88.75);
    }

    
}
class GetStudent
{
    static void Main()
    {
        GreetStudent s = new GreetStudent();
        var student = s.studentdetails();

        Console.WriteLine(student.name);
        Console.WriteLine(student.age);
        Console.WriteLine(student.height);
        Console.WriteLine(student.marks);
    }
}
