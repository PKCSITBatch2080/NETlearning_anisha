using System;

class Program
{
    static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount(123, 0.05m);
        CheckingAccount checking = new CheckingAccount(456, 100);

        savings.Deposit(1500);
        checking.Deposit(700);

        Console.WriteLine("Savings Account Balance: " + savings.GetBalance());
        Console.WriteLine("Checking Account Balance: " + checking.GetBalance());

        savings.Withdraw(400);
        checking.Withdraw(250);

        Console.WriteLine("Savings Account Balance after withdrawal: " + savings.GetBalance());
        Console.WriteLine("Checking Account Balance after withdrawal: " + checking.GetBalance());
    }
}
