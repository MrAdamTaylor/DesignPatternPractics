using UnityEngine;

public class RegularState : BankAccountState
{
    public RegularState(float balance, BankAccount bankAccount)
    {
        Balance = balance;
        BankAccount = bankAccount;
    }

    public override void Deposit(float amount)
    {
        Debug.Log($"In {GetType()}, depositing {amount}");
        Balance += amount;
        if (Balance >= 1000)
        {
            BankAccount.BankAccountState = new GoldState(Balance, BankAccount);
        }
    }

    public override void Withdraw(float amount)
    {
        Debug.Log($"In {GetType()}, withdrawing {amount} from {Balance}");
        Balance -= amount;
        if (Balance < 0)
        {
            BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
        }
    }
}