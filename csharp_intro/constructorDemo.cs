using System;
 class constructorDemo
    {
    string name = "janusonu";
    string address = "kulkarni";
    string age = "12";

    constructorDemo()
    {
        Console.WriteLine("displaying the details");
        Console.WriteLine(name);
        Console.WriteLine(this.address);

    }
    static void Main()
       {
        constructorDemo cd = new constructorDemo();  // at this creating object time constructor will get executed.
       
       }

    }
class Animal
{
    string dogname = "dinku";
    string color = "black&white";
    string breed = "golden retriever";

    Animal()
    {
        Console.WriteLine("lets displays the dog details below");
        Console.WriteLine($"the dog name is:{ this.dogname}");
        Console.WriteLine($"dog color is:{this.color}");
        Console.WriteLine($"the breed is:{this.breed}");
    }


    static void Main()
    {
        Animal animal = new Animal();
       
    }



}
