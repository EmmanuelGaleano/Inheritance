namespace Inheritance.Core
{
    public class Square : GeometricFigure
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

        // constructor: (name, A)
        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        public override double GetArea() => A * A;
        public override double GetPerimeter() => 4 * A;
    }
}
