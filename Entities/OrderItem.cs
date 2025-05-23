using System;

namespace Workspace.Entities;

public class OrderItem
{
    public int Quantity { get; private set; }
    public double Price { get; private set; }
    public Product Product { get; private set; }

    public OrderItem(int quantity, Product product)
    {
        Quantity = quantity;
        Product = product;
        Price = Product.Price;
    }

    public double SubTotal()
    {
        return Quantity * Price;
    }

    public override string ToString()
    {
        return $"{Product.Name}, ${Price}, Quantity: {Quantity}, Subtotal: ${SubTotal()}";
    }
}
