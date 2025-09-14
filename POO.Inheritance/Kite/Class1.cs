namespace Geometry
{
    public class Kite : Rhombus
    {
        // We'll reuse fields where makes sense.
        // Constructor params: (name, A, D1, D2, B)
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

        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            B = b;
        }

        // Area same as rhombus: (D1 * D2) / 2
        public override double GetArea() => (D1 * D2) / 2.0;
        // Perimeter = 2 * (A + B)
        public override double GetPerimeter() => 2 * (A + B);
    }
}
