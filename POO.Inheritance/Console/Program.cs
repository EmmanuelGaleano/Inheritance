using System;
using System.Collections.Generic;
using System.Globalization;
using Inheritance.Core;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        var circle = new Circle(nameof(Circle), 5);
        var square = new Square(nameof(Square), 10);
        var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);          // (A, D1, D2)
        var kite = new Kite(nameof(Kite), 7, 6, 5, 8);                // (A, D1, D2, B)
        var rectangle = new Rectangle(nameof(Rectangle), 4.568, 67.790); // (A, B)
        var parallelogram = new Parallelogram(nameof(Parallelogram), 14.65, 54.67, 23.09); // (A, B, H)
        var triangle = new Triangle(nameof(Triangle), 45.56, 12.34, 27.09, 15); // (A, B, C, H)
        var trapeze = new Trapeze(nameof(Trapeze), 10, 30, 10, 50, 200); // (A, B, C, D, H) //

        var figures = new List<GeometricFigure>()
        {
            circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze
        };

        foreach (var fig in figures)
        {
            Console.WriteLine(fig);
        }
    }
}
