using System;

namespace Workspace.Entities;

public sealed class Individual : TaxPayer
{
    public double HealthExpenditures { get; set; }

    public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
    {
        HealthExpenditures = healthExpenditures;
    }

    public override double Tax()
    {
        double tax;
        tax = AnualIncome < 20000.00 ? AnualIncome * .15 : AnualIncome * .25;
        tax -= HealthExpenditures > 0.00 ? HealthExpenditures * 0.5 : 0.0;
        return tax;
    }
}