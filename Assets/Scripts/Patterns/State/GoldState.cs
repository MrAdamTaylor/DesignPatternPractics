using UnityEngine;

namespace Patterns.State
{
    public class GoldState : BankAccountState
    {
        public GoldState(float balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(float amount)
        {
            Debug.Log($"In {GetType()}, depositing {amount} " +
                      $"+ 10% bonus: {amount/10}");
            Balance += amount + (amount / 10);
        }

        public override void Withdraw(float amount)
        {
            Debug.Log($"In {GetType()}, withdrawing {amount} from {Balance}");

            Balance -= amount;
            if (Balance < 1000 && Balance >= 0)
            {
                BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
            }
            else if(Balance < 0)
            {
                BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}
