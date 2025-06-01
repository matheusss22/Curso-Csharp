using System;
using System.Text;
using System.Globalization;

namespace Workspace.Entities;

public class ImportedProduct : Product
{
    public double CustomsFee { get; private set; }

    public ImportedProduct() { }

    public ImportedProduct(string name, double price, double customsFee)
        : base(name: name, price: price)
    {
        CustomsFee = customsFee;
    }

    private double PriceTotal()
    {
        return Price + CustomsFee;
    }

    public sealed override string PriceTag()
    {
        StringBuilder sb = new("");
        sb.Append(Name);
        sb.Append(" $ ");
        sb.Append(PriceTotal().ToString("F2", CultureInfo.InvariantCulture));
        sb.Append(" (Customs fee: $ ");
        sb.Append(CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
        sb.AppendLine(")");
        return sb.ToString();
    }
}
