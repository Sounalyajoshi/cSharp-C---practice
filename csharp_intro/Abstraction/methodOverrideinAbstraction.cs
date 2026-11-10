using System;

abstract class Animals
{
    // Abstract method
    public abstract void Sound();
}
class Dog : Animals
{
    // Overriding abstract method
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class OverrideProgram
{
    static void Main()
    {
        Dog obj = new Dog();

        obj.Sound();
    }
}