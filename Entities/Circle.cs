using System;
using Workspace.Entities.Emuns;

namespace Workspace.Entities;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(Color color, double radius) : base(color)
    {
        Radius = radius;
    }

    public override sealed double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
