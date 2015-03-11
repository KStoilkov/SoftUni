using System;

namespace _10.InsideACircleAndOutsideRectangle
{
    class CircleAndRectangle
    {
        static void Main()
        {
            // Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
            // and out of the rectangle R(top=1, left=-1, width=6, height=2). 

            Console.Write("X coordinates: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y coordinates: ");
            double y = double.Parse(Console.ReadLine());

            double r = 1.5;

            bool inCircle = r * r >= ((x - 1) * (x - 1)) + ((y - 1)*(y - 1));
            bool inRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);
            bool inCircleAndOutOfRectangle = inCircle && !inRectangle;

            if (inCircleAndOutOfRectangle == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
