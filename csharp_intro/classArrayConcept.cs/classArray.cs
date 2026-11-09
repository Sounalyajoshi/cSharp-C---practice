using System;

class student
{
    public void DisplayNames(string[] names)
    {
        Console.WriteLine("student names: ");
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }


    public void DisplayCourse(string[] courses)
    {
        Console.WriteLine("student courses: ");

        foreach(string course in courses)
        {
            Console.WriteLine(course);
        }
    }
   

}
class classArrayProgram
{
    static void Main()
    {
        string[] students = { "arun", "rahul", "kiran" };
        string[] courses = { "c#", "javascript", "angular" };

        student obj = new student();
        obj.DisplayNames(students);

        obj.DisplayCourse(courses);
    }

}


