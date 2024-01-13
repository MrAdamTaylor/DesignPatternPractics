public class BankAccount
{
    public BankAccountState BankAccountState { get; set; }

    public float Balance
    {
        get { return BankAccountState.Balance; }
    }

    public BankAccount()
    {
        BankAccountState = new RegularState(200, this);
    }

    public void Deposite(float amount)
    {
        BankAccountState.Deposit(amount);
    }

    public void Withdraw(float amount)
    {
        BankAccountState.Withdraw(amount);
    }
}