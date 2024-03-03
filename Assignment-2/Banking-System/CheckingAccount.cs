public class CheckingAccount : Account
{
    public decimal OverdraftLimit { get; set; }

    public CheckingAccount(int accountId, decimal overdraftLimit) : base(accountId)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if (balance + OverdraftLimit >= amount)
            balance -= amount;
        else
            Console.WriteLine("Transaction declined: Overdraft limit exceeded");
    }
}
