using System;

namespace Workspace.Entities;

public sealed class Company : TaxPayer
{
    public int NumberOfEmployees { get; set; }

    public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
    {
        NumberOfEmployees = numberOfEmployees;
    }

    public override double Tax()
    {
        return NumberOfEmployees <= 10 ? AnualIncome * .16 : AnualIncome * .14;
    }
}
