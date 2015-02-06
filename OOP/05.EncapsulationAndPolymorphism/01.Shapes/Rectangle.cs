namespace _01.Shapes
{
    public class Rectangle : BasicShape
    {
        public Rectangle(double width, double heigth) : base (width, heigth)
        {
            
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
           return (this.Width * 2) + (this.Height * 2);
        }
    }
}
