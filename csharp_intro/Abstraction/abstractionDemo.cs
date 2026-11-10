using System;


abstract class ATM
{
   
    public abstract void Withdraw();

    
    public void CheckBalance()
    {
        Console.WriteLine("Checking account balance");
    }
}
class SBI : ATM
{
    public override void Withdraw()
    {
        Console.WriteLine("SBI withdrawal successful");
    }
}
class AtmProgram
{
    static void Main()
    {
        SBI obj = new SBI();

        obj.Withdraw();
        obj.CheckBalance();
    }
}


