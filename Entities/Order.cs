using System;
using System.Globalization;
using System.Text;
using Workspace.Entities.Enums;

namespace Workspace.Entities;

public class Order
{
    public DateTime Moment { get; private set; }
    public OrderStatus Status { get; private set; }
    public Client Client { get; private set; }
    public List<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();

    public Order(OrderStatus status, Client client)
    {
        Moment = DateTime.Now;
        Status = status;
        Client = client;
    }

    public void AddItem(OrderItem orderItem)
    {
        OrderItems.Add(orderItem);
    }

    public void RemoveItem(OrderItem orderItem)
    {
        OrderItems.Remove(orderItem);
    }

    public double Total()
    {
        double sum = 0;

        foreach (var orderItem in OrderItems)
        {
            sum += orderItem.SubTotal();
        }

        return sum;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("ORDER SUMMARY:");
        sb.Append("Order moment: ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.Append("Order status: ");
        sb.AppendLine(Status.ToString());
        sb.Append("Client: ");
        sb.AppendLine(Client.ToString());
        sb.AppendLine("Order items: ");
        foreach (var orderItem in OrderItems)
            sb.AppendLine(orderItem.ToString());
        sb.Append("Total price: ");
        sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

        return sb.ToString();
    }
}
