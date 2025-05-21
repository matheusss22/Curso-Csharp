using System;
using Workspace.Entities;
using Workspace.Entities.Enums;

namespace Workspace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };


            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(order);
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
