using System;
class Parent
{
    public int id = 101;

    public void DisplayParent()
    {
        Console.WriteLine("This is Parent Class");
        Console.WriteLine("Parent ID: " + id);
    }
}
class Child : Parent
{
    public string name = "Rahul";

    public void DisplayChild()
    {
        Console.WriteLine("This is Child Class");
        Console.WriteLine("Child Name: " + name);
    }
}
class InheritanceProgram
{
    static void Main()
    {
        Child obj = new Child();

        obj.DisplayParent();
        Console.WriteLine("Parent ID: " + obj.id);

        obj.DisplayChild();
        Console.WriteLine("Child Name: " + obj.name);
    }
}