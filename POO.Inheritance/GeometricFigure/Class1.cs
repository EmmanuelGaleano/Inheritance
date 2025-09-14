using System;
using System.Globalization;

namespace Geometry
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
            // Usamos InvariantCulture para que se vean comas como separador de miles y punto decimal.
            var area = GetArea().ToString("N5", CultureInfo.InvariantCulture);
            var peri = GetPerimeter().ToString("N5", CultureInfo.InvariantCulture);

            // Formato similar al de la imagen (ajusta espacios si quieres idéntico)
            return $"{Name.PadRight(12)} => Area......: {area.PadLeft(12)}    Perimeter: {peri.PadLeft(12)}";
        }
    }
}
