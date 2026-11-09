using System;

class ParentProperty
{
    public void DisplayParent()
    {
        Console.WriteLine("Parent class method");
    }

    public void Show()
    {
        Console.WriteLine("Parent Show method");
    }
}

class ChildProperty : ParentProperty
{
    public void DisplayChild()
    {
        Console.WriteLine("Child class method");
    }

    public void ShowChild()
    {
        Console.WriteLine("Child Show method");
    }
}

class UPCASTINGProgram
{
    static void Main()
    {
        // Upcasting
        ParentProperty obj = new ChildProperty();

        obj.DisplayParent();
        obj.Show();

       
    }
}
