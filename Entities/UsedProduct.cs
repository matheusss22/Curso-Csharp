using System;
using System.Text;
using System.Globalization;

namespace Workspace.Entities;

public class UsedProduct : Product
{
    public DateTime ManufactureDate { get; private set; }

    public UsedProduct() { }

    public UsedProduct(string name, double price, DateTime manufactureDate)
        : base(name: name, price: price)
    {
        ManufactureDate = manufactureDate;
    }

    public sealed override string PriceTag()
    {
        StringBuilder sb = new("");
        sb.Append(Name);
        sb.Append(" (used) $ ");
        sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
        sb.Append(" (Manufacture date: ");
        sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));
        sb.AppendLine(")");
        return sb.ToString();
    }
}
