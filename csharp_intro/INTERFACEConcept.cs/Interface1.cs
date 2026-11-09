
using System;

// Interface
interface IStudent
{
    void Display();
    void GetMarks();
}

// Implementing interface
class Students : IStudent
{
    public void Display()
    {
        Console.WriteLine("Student Name: Rahul");
    }

    public void GetMarks()
    {
        Console.WriteLine("Student Marks: 85");
    }
}

class interfaceProgram1
{
    static void Main()
    {
        Students obj = new Students();

        obj.Display();
        obj.GetMarks();
    }
}