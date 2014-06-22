using System;

namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            // Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).

            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y = double.Parse(Console.ReadLine());

            bool inside = (Math.Sqrt((x*x)+(y*y))) <= 2;
            Console.WriteLine("Inside: " + inside);
        }
    }
}
