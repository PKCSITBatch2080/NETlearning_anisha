public interface IBankTransaction
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
}