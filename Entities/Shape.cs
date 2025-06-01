using System;
using Workspace.Entities.Emuns;

namespace Workspace.Entities;

public abstract class Shape
{
    public Color Color { get; set; }

    public Shape(Color color)
    {
        Color = color;
    }

    public abstract double Area();
}
