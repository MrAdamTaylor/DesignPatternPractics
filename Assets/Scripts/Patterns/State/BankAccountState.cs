public abstract class BankAccountState
{
    public BankAccount BankAccount
    {
        get;
        protected set;
    } = null!;

    public float Balance { get; protected set; }

    public abstract void Deposit(float amount);
    
    public abstract void Withdraw(float amount);
}