using System;

namespace Sparky;

public class BankAccount
{
    private double balance { get; set; }
    private readonly ILogBook _logBook;
    public BankAccount(ILogBook logBook)
    {
        _logBook = logBook;
        balance = 0;
    }
    public bool Deposit(double amount)
    {
        _logBook.Message($"Depositing {amount}");
        balance += amount;
        return true;
    }
    public bool Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    public double GetBalance()
    {
        return balance;
    }
}