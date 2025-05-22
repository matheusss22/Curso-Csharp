using System;
using System.Globalization;
using Workspace.Entities;
using Workspace.Entities.Enums;

namespace Workspace
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName);
            Worker worker = new Worker(name, workerLevel, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Enter #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture);

            string dateFormated = date2.ToString("MM/yyyy");
            double income = worker.income(date2.Month, date2.Year);

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department= {worker.Department}");
            Console.WriteLine($"Income for {dateFormated}: {income.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
