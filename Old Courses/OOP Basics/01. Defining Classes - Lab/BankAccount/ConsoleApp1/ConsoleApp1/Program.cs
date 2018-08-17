using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
    //    Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

    //    string input;

    //    while ((input = Console.ReadLine()) != "End")
    //    {
    //        var commands = input.Split();
    //        string action = commands[0];

    //        switch (action)
    //        {
    //            case "Create":
    //                Create(commands, accounts);
    //                break;
    //            case "Deposit":
    //                Deposit(commands, accounts);
    //                break;
    //            case "Withdraw":
    //                Withdraw(commands, accounts);
    //                break;
    //            case "Print":
    //                Print(commands, accounts);
    //                break;
                
    //        }

    //    }
    //}

    //private static void Print(string[] commands, Dictionary<int, BankAccount> accounts)
    //{
    //    int id = int.Parse(commands[1]);
    //    if (accounts.ContainsKey(id))
    //    {
    //        Console.WriteLine(accounts[id].ToString()); 
    //    }
    //    else
    //    {
    //        Console.WriteLine("Account does not exist");
    //    }
    //}

    //private static void Withdraw(string[] commands, Dictionary<int, BankAccount> accounts)
    //{
    //    var acc = new BankAccount();
    //    decimal amount = decimal.Parse(commands[2]);
    //    int id = int.Parse(commands[1]);

    //    if (accounts.ContainsKey(id))
    //    {
    //        if (accounts[id].Balance >= amount)
    //        {
    //            accounts[id].Balance -= amount;

    //        }
    //        else
    //        {
    //            Console.WriteLine("Insufficient balance");
    //        }
    //    }
    //    else
    //    {

    //        Console.WriteLine("Account does not exist");
    //    }

    //}

    //private static void Deposit(string[] commands, Dictionary<int, BankAccount> accounts)
    //{
    //    var acc = new BankAccount();
    //    int id = int.Parse(commands[1]);
    //    decimal amount = decimal.Parse(commands[2]);

    //    if (accounts.ContainsKey(id))
    //    {
    //        accounts[id].Balance += amount;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Account does not exist");
    //    }
    //}

    //private static void Create(string[] commands, Dictionary<int, BankAccount> accounts)
    //{
    //    int id = int.Parse(commands[1]);
    //    if (accounts.ContainsKey(id))
    //    {
    //        Console.WriteLine("Account already exists");
    //    }
    //    else
    //    {
    //        var acc = new BankAccount();
    //        acc.ID = id;
    //        accounts.Add(id, acc);

    //    }
    }
}

