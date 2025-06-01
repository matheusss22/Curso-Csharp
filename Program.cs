using System;
using Workspace.Entities;
using System.Globalization;

namespace Workspace;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = [];

        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("");
            Console.WriteLine($"Product #{i} data:");

            Console.Write("Common, used or imported (c/u/i)? ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            switch (op)
            {
                case 'c':
                    products.Add(new Product(name, price));
                    break;
                case 'u':
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                    break;
                case 'i':
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                    break;

                default: break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("PRICE TAGS:");

        foreach (var product in products)
        {
            Console.Write(product.PriceTag());
        }
    }
}
