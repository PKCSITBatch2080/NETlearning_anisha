public class SavingsAccount : Account
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(int accountId, decimal interestRate) : base(accountId)
    {
        InterestRate = interestRate;
    }

    public override void Withdraw(decimal amount)
    {
        base.Withdraw(amount);
        // Add interest
        balance *= (1 + InterestRate);
    }
}
