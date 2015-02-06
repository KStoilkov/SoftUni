namespace _01.Shapes
{
    public class Triangle : BasicShape
    {
        public double B { get; set; }

        public double C { get; set; }

        public Triangle(double width, double heigth, double b, double c)
            : base (width, heigth)
        {
            this.B = b;
            this.C = c;
        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.B + this.C;
        }
    }
}
