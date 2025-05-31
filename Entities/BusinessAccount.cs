using System;
using System.Text;

namespace Workspace.Entities;

public sealed class BusinessAccount : Account
{
    public double LoanLimit { get; set; }

    public BusinessAccount() { }

    public BusinessAccount(int number, string holder, double balance, double loanLimit)
        : base(number: number, holder: holder, balance: balance)
    {
        LoanLimit = loanLimit;
    }

    public void Loan(double amount)
    {
        if (amount <= LoanLimit) { Balance += amount; }
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
        sb.Append("LoanLimit = ");
        sb.AppendLine(LoanLimit.ToString("F2", System.Globalization.CultureInfo.InstalledUICulture));

        return sb.ToString();
    }
}
