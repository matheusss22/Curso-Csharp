using System;
using System.Globalization;
using Workspace.Entities;

namespace Workspace;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a list of employees
        List<Employee> employees = [];

        // Get user input for number of employees
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            // Get user input for employee type
            Console.WriteLine($"Employee #{i} data: ");
            Console.Write("Outsourced (y/n)? ");
            char userInput = char.Parse(Console.ReadLine());
            bool isOutsourced = userInput == 'y';

            // Get user input for employee details
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Create employee object based on user input
            if (isOutsourced)
            {
                Console.Write("Additional charge: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
            }
            else
            {
                employees.Add(new Employee(name, hours, valuePerHour));
            }
        }

        Console.WriteLine("PAYMENTS:");

        // Print employee payments
        foreach (var employee in employees)
        {
            Console.Write(employee);
        }
    }
}
