//Create a base class `Account` with a virtual method `CalculateInterest()`. 
//Derive a class `SavingsAccount` and override `CalculateInterest()`.
// Now, prevent further overriding by marking it as `sealed`.

class Account
{
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Base Class Method");
    }
}

class SavingsAccount : Account
{
    public override void CalculateInterest()
    {
        Console.WriteLine("Derived Class Method");
    }
}

//class SavingsAccount : Account
//{
//    public override sealed void CalculateInterest()
//    {
//        Console.WriteLine("Derived Class Method");
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();
        account.CalculateInterest();

        SavingsAccount savingsAccount = new SavingsAccount();
        savingsAccount.CalculateInterest();
    }
}