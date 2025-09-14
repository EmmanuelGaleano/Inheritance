namespace Inheritance.Core
{
    public class Triangle : GeometricFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double H { get; }

        // constructor: (name, A, B, C, H)
        public Triangle(string name, double a, double b, double c, double h) : base(name)
        {
            if (a <= 0 || b <= 0 || c <= 0 || h <= 0) throw new System.ArgumentException("All values must be > 0");
            A = a; B = b; C = c; H = h;
        }

        public override double GetArea() => (B * H) / 2.0;
        public override double GetPerimeter() => A + B + C;
    }
}
