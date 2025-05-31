using System;
using Workspace.Entities;


namespace Workspace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Broew", 100.00, 500);
            Console.WriteLine(account.Balance);
        }
    }
}
