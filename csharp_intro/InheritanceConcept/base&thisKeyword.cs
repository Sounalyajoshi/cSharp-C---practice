using System;
class Parents
{
    public string name = "Parent";

    public Parents()
    {
        Console.WriteLine("Parent Constructor Called");
    }

    public void Display()
    {
        Console.WriteLine("Parent Name: " + name);
    }
}
class Children : Parents
{
    public string name = "Child";

    public Children() : base()
    {
        Console.WriteLine("Child Constructor Called");
    }

    public void Show()
    {
        Console.WriteLine("Child Name: " + this.name);

        Console.WriteLine("Parent Name: " + base.name);

        base.Display();
    }
}
class childProgram
{
    static void Main()
    {
        Children obj = new Children();

        obj.Show();
    }
}