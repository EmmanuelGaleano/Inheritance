namespace Geometry
{
    public class Rectangle : Square
    {
        private double _b;
        public double B
        {
            get => _b;
            private set
            {
                if (value <= 0) throw new System.ArgumentException("B must be > 0");
                _b = value;
            }
        }

        // constructor: (name, A, B)
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);
    }
}
