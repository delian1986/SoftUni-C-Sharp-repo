using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    private int id;
    private decimal balance;

    public int ID
    {
        get
        {
            return this.id;
        }
        set
        {
            if (value > 0)
            {
                this.id = value;
            }
        }
    }

    public decimal Balance
    {
        get
        {
            return this.balance;
        }
        set
        {
            this.balance = value;
        }
    }

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (this.balance - amount>=0)
        {
            this.Balance -= amount;

        }
        else
        {
            throw new ArgumentException("You cannot withdraw more than you have in the balance. Add more $$$");

        }
    }

    public override string ToString()
    {
        return $"Account ID{this.ID}, balance {this.Balance:f2}";
    }


}
