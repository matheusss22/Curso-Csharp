using System;
using Workspace.Entities.Emuns;

namespace Workspace.Entities;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(Color color, double width, double height) : base(color)
    {
        Width = width;
        Height = height;
    }

    public override sealed double Area()
    {
        return Width * Height;
    }
}
