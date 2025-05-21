using System;
using Workspace.Entities.Enums;

namespace Workspace.Entities;

public class Worker
{
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }

    public Department Department { get; set; }
    public List<HourContract> Contracts { get; set; } = new List<HourContract>();

    public Worker()
    {

    }

    public Worker(string name, WorkerLevel level, double baseSalary, Department department)
    {
        Name = name;
        Level = level;
        BaseSalary = baseSalary;
        Department = department;
    }

    public void AddContract(HourContract hourContract)
    {
        Contracts.Add(hourContract);
    }

    public void RemoveContract(HourContract hourContract)
    {
        Contracts.Remove(hourContract);
    }

    public double income(int year, int month)
    {
        double sum = 0;

        foreach (var hourContract in Contracts)
        {
            if (hourContract.Date.Year == year && hourContract.Date.Month == month)
            {
                sum += hourContract.TotalValue();
            }
        }

        return sum;
    }
}
