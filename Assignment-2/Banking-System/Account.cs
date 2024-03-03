public class Account : IBankTransaction
{
    protected int accountId;
    protected decimal balance;

    public Account(int accountId)
    {
        this.accountId = accountId;
        balance = 0;
    }

    public virtual void Deposit(decimal amount)
    {
        balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        if (balance >= amount)
            balance -= amount;
        else
            Console.WriteLine("Insufficient funds");
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
