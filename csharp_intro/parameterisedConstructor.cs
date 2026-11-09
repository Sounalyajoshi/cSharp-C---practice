using System;
class parameterisedConstructor
{
    string personName;
    string address;
    int accountnum;
    string IFSCCODE;

    parameterisedConstructor( string personName,string address,int accountnum,string IFSCCODE)
    {
        this.personName = personName;
        this.address = address;
        this.accountnum = accountnum;
        this.IFSCCODE = IFSCCODE;

    }
    public void Display()
    {
        Console.WriteLine($"name is:{this.personName} \n address is:{this.address}\n his accountnum is:{this.accountnum}\n bank ifsc code is:{this.IFSCCODE}");
    }
    static void Main()
    {
        parameterisedConstructor pc = new parameterisedConstructor("smith","banglauru",1246322745,"sbi00000000");
        pc.Display();

    }


}
    

