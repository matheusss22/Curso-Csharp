using System;

namespace Workspace.Entities;

public class OutsourcedEmployee : Employee
{
    public double AdditionalCharge { get; set; }

    public OutsourcedEmployee() { }

    public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
        : base(name: name, hours: hours, valuePerHour: valuePerHour)
    {
        AdditionalCharge = additionalCharge;
    }

    public sealed override double Payment()
    {
        // Calculate payment with additional charge
        return base.Payment() + AdditionalCharge * 1.1;
    }
}
