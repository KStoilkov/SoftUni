namespace _01.Shapes
{
    public abstract class BasicShape : IShape
    {
        protected double Height { get; set; }

        protected double Width { get; set; }

        protected BasicShape(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
