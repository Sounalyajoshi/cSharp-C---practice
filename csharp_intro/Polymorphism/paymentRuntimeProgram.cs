using System;
class Payment
{
    public virtual void Pay()
    {
        Console.WriteLine("Making a payment");
    }
}
class GooglePay : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment through Google Pay");
    }
}
class CreditCard : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment through Credit Card");
    }
}
class PaymentruntimeProgram
{
    static void Main()
    {
        Payment p1 = new GooglePay();
        Payment p2 = new CreditCard();

        p1.Pay();
        p2.Pay();
    }
}