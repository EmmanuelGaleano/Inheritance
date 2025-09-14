namespace Inheritance.Core
{
    public class Rectangle : GeometricFigure
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

        // constructor: (name, A, B)
        public Rectangle(string name, double a, double b) : base(name)
        {
            A = a;
            B = b;
        }

        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }
}
