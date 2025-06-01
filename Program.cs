using System;
using System.Globalization;
using Workspace.Entities;

namespace Workspace;

class Program
{
    static void Main(string[] args)
    {
        List<Account> list = [];

        list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
        list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
        list.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
        list.Add(new BusinessAccount(1004, "Ana", 500.00, 500.00));

        double sum = 0.0;

        foreach (var acc in list)
        {
            sum += acc.Balance;
        }

        Console.WriteLine("Total balance = " + sum.ToString("F2", CultureInfo.InvariantCulture));

        foreach (var acc in list)
        {
            acc.Withdraw(10.0);
        }

        foreach (var acc in list)
        {
            Console.WriteLine("Update balance for account"
                + acc.Number
                + ": "
                + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
            );
        }
    }
}
