using System;
using Workspace.Entities;

namespace Workspace;

public class Program
{
    public static void Main(string[] args)
    {
        Account acc = new Account(1001, "Alex", 0.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 100.00);

        Console.WriteLine(acc);
        Console.WriteLine(bacc);

        // UPCASTING
        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
        Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

        Console.WriteLine(acc1);
        Console.WriteLine(acc2);
        Console.WriteLine(acc3);

        // DOWNCASTING - Má prática de programação (Operação insegura!)
        //BusinessAccount acc4 = (BusinessAccount)acc2;
        BusinessAccount acc4 = acc2 as BusinessAccount;
        Console.WriteLine(acc4);
        acc4.Loan(100.00);
        Console.WriteLine(acc4);
        //acc2.Loan(); --> Erro pois ela foi instânciada como Account

        //BusinessAccount acc5 = (BusinessAccount)acc3; // --> InvalidCastException

        if (acc3 is BusinessAccount)
        {
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            BusinessAccount acc5 = acc3 as BusinessAccount;
            Console.WriteLine("Deposit");
            acc5.Deposit(100.00);
            acc5.Loan(200.00);
            Console.WriteLine("Loan!");
            Console.WriteLine(acc5);
        }

        if (acc3 is SavingsAccount)
        {
            //SavingsAccount acc5 = (SavingsAccount)acc3;
            SavingsAccount acc5 = acc3 as SavingsAccount;
            Console.WriteLine("Deposit");
            acc5.Deposit(100.00);
            acc5.UpdateBalance();
            Console.WriteLine("Updade Balance!");
            Console.WriteLine(acc5);
        }
    }
}
