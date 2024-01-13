using System.Collections;
using System.Collections.Generic;
using Patterns;
using UnityEngine;

public class StateLauncher : DesignPatternLauncher
{
    public override void Launch()
    {
        Debug.Log("Запус паттерна - состояние!");

        BankAccount bankAccount = new();
        bankAccount.Deposite(100);
        bankAccount.Withdraw(500);
        bankAccount.Withdraw(100);
        
        bankAccount.Deposite(200);
        bankAccount.Withdraw(3000);
        bankAccount.Deposite(3000);
        bankAccount.Deposite(100);
        
        Debug.Log("");
    }
}