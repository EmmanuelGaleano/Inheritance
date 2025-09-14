using System.Drawing;

namespace Geometry
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public double H
        {
            get => _h;
            private set
            {
                if (value <= 0) throw new System.ArgumentException("H must be > 0");
                _h = value;
            }
        }

        // constructor: (name, A, B, H)
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public override double GetArea() => B * H; // area = base * height (B * H)
        public override double GetPerimeter() => 2 * (A + B);
    }
}
