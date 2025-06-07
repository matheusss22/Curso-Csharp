using System;
using System.Globalization;
using Workspace.Entities;

namespace Workspace;

class Program
{
    static void Main(string[] args)
    {
        List<TaxPayer> taxPayers = [];

        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax payer #{i} data:");
            Console.Write($"Individual or company(i/c)? ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual income: ");
            double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (op == 'i')
            {
                Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
            }
            else if (op == 'c')
            {
                Console.Write("Number of employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine());
                taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
            }
        }

        Console.WriteLine("\nTAXES PAID:");

        double sum = 0;

        foreach (var taxPayer in taxPayers)
        {
            Console.WriteLine($"{taxPayer.Name}: ${taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            sum += taxPayer.Tax();
        }

        Console.WriteLine($"\nTOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}


