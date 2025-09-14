using System.Globalization;

namespace Inheritance.Core
{
    public abstract class GeometricFigure
    {
        public string Name { get; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            // We use InvariantCulture so that numbers have a decimal point and thousands separator.
            var area = GetArea().ToString("N5", CultureInfo.InvariantCulture);
            var peri = GetPerimeter().ToString("N5", CultureInfo.InvariantCulture);

            // Name aligned to the longest (Parallelogram = 13 characters)
            // Area and Perimeter aligned to 12 characters
            return
                $"{Name.PadRight(13)}" +             // Name
                $"   => Area......: {area.PadLeft(12)}" + // Area
                $"    Perimeter: {peri.PadLeft(12)}";  // Perimeter
        }
    }
}
