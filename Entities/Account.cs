using System;
using System.ComponentModel;
using System.Text;

namespace Workspace.Entities;

public class Account
{
    public int Number { get; private set; }
    public string Holder { get; private set; }
    public double Balance { get; protected set; }

    public Account() { }

    public Account(int number, string holder, double balance)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
    }

    public virtual void Withdraw(double amount)
    {
        Balance -= amount + 5.0;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append("Number = ");
        sb.AppendLine(Number.ToString());
        sb.Append("Holder = ");
        sb.AppendLine(Holder);
        sb.Append("Balance = ");
        sb.AppendLine(Balance.ToString("F2", System.Globalization.CultureInfo.InstalledUICulture));

        return sb.ToString();
    }

}
