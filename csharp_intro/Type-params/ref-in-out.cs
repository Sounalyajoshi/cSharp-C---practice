using System;
namespace refInOutconcept{
class RefIntOut
{
    static void change(int number)
    {
        number = 100;

    }
    static void Main()
    {
        int a = 400;
        change(a);
        Console.WriteLine(a);

    }
}
class Student
{
    public string name;
    public Student(string n)
        {
            name = n;
        }
}
    class InProgram
    {
        static void DisplayStudent(in Student s)
        {
            Console.WriteLine(s.name); // this gave value to the field name.
         
        }
        static void Main()
        {
            Student s1 = new Student("ravi");
            DisplayStudent(in s1);
            Console.WriteLine(s1.name);
        }
    }
}