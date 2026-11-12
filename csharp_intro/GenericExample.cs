using System;
class genericProgram
{
    static void Display<T>(T value)
    {
        Console.WriteLine(value);
    }
    static void Main()
    {
        genericProgram gp = new genericProgram();
        genericProgram.Display<int>(100);
        genericProgram.Display<string>("janu");

        genericProgram.Display<double>(100.00);
    }
}
class PersonDetails
{
    static void DisplayDetails<T>(T data)
    {
        Console.WriteLine(data);
    }
    static void Main()
    {
        PersonDetails.DisplayDetails<string>("ravi");
        PersonDetails.DisplayDetails<int>(25);

        PersonDetails.DisplayDetails<double>(5.4);



    }
}