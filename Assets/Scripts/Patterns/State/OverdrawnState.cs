using UnityEngine;

public class OverdrawnState : BankAccountState
{
    public OverdrawnState(float balance, BankAccount bankAccount)
    {
        Balance = balance;
        BankAccount = bankAccount;
    }

    public override void Deposit(float amount)
    {
        Debug.Log($"In {GetType()}, depositing {amount}");
        Balance += amount;
        if (Balance >= 0)
        {
            BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
        }
    }

    public override void Withdraw(float amount)
    {
        Debug.Log($"In {GetType()}, cannot withdrawing balance {Balance}");
    }
}