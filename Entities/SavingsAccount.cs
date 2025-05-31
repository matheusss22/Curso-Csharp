using System;
using System.Text;

namespace Workspace.Entities;

public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount() { }

    public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number: number, holder: holder, balance: balance)
    {
        InterestRate = interestRate;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
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
        sb.Append("InterestRate = ");
        sb.AppendLine(InterestRate.ToString("F2", System.Globalization.CultureInfo.InstalledUICulture));

        return sb.ToString();
    }
}
