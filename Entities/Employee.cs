using System;
using System.Text;

namespace Workspace.Entities;

public class Employee
{
    public string Name { get; set; }
    public int Hours { get; set; }
    public double ValuePerHour { get; set; }

    public Employee() { }

    public Employee(string name, int hours, double valuePerHour)
    {
        Name = name;
        Hours = hours;
        ValuePerHour = valuePerHour;
    }

    public virtual double Payment()
    {
        // Calculate payment based on hours and value per hour
        return Hours * ValuePerHour;
    }

    public sealed override string ToString()
    {
        StringBuilder sb = new StringBuilder("");
        sb.Append(Name);
        sb.Append(" - $ ");
        sb.AppendLine(Payment().ToString("F2", System.Globalization.CultureInfo.InstalledUICulture));

        return sb.ToString();
    }
}
