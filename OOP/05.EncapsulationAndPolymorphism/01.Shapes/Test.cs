namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            IList<IShape> shapes = new List<IShape>
            {
                new Rectangle(3.2, 5.1),
                new Triangle(7.3, 8.5, 4, 6),
                new Circle(5.5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType() + " Area: " + shape.CalculateArea().ToString("F"));
                Console.WriteLine(shape.GetType() + " Perimeter: " + shape.CalculatePerimeter().ToString("F"));
            }
        }
    }
}
