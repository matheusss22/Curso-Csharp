using System;
using System.Globalization;
using Workspace.Entities;
using Workspace.Entities.Emuns;

namespace Workspace;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];

        Console.Write("Enter the number of shapes: ");
        int numShapes = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numShapes; i++)
        {
            Console.WriteLine($"Shape #{i} data:");
            Console.Write("Rectangle or Circle (r/c)? ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (op == 'r')
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Rectangle(color, width, height));
            }
            else
            {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Circle(color, radius));
            }
        }

        Console.WriteLine("");
        Console.WriteLine("SHAPE AREAS:");

        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


