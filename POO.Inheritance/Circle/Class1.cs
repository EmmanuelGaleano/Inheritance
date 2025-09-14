using System;

namespace Geometry
{
    public class Circle : GeometricFigure
    {
        private double _r;
        public double R
        {
            get => _r;
            private set
            {
                if (value <= 0) throw new ArgumentException("R must be > 0");
                _r = value;
            }
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public override double GetArea() => Math.PI * R * R;
        public override double GetPerimeter() => 2 * Math.PI * R;
    }
}
