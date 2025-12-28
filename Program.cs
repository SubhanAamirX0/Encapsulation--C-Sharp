using Encapuslation;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("Muhammad Subhan", 15000);

        account.DisplayAccInfo();
        account.Depost(5000);
        account.Withdraw(2500);

        Console.WriteLine($"New balance : {account.GetBalance()}");
    }
}