namespace Inheritance.Core
{
    public class Parallelogram : GeometricFigure
    {
        private double _a;
        public double A
        {
            get => _a;
            private set
            {
                if (value <= 0) throw new ArgumentException("A must be > 0");
                _a = value;
            }
        }

        private double _b;
        public double B
        {
            get => _b;
            private set
            {
                if (value <= 0) throw new ArgumentException("B must be > 0");
                _b = value;
            }
        }

        private double _h;
        public double H
        {
            get => _h;
            private set
            {
                if (value <= 0) throw new ArgumentException("H must be > 0");
                _h = value;
            }
        }

        // constructor: (name, A, B, H)
        public Parallelogram(string name, double a, double b, double h) : base(name)
        {
            A = a;
            B = b;
            H = h;
        }

        public override double GetArea() => B * H;
        public override double GetPerimeter() => 2 * (A + B);
    }
}
