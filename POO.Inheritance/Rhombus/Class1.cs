namespace Geometry
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1
        {
            get => _d1;
            private set
            {
                if (value <= 0) throw new System.ArgumentException("D1 must be > 0");
                _d1 = value;
            }
        }

        public double D2
        {
            get => _d2;
            private set
            {
                if (value <= 0) throw new System.ArgumentException("D2 must be > 0");
                _d2 = value;
            }
        }

        // constructor: (name, A, D1, D2)
        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public override double GetArea() => (D1 * D2) / 2.0;
        public override double GetPerimeter() => 4 * A;
    }
}
