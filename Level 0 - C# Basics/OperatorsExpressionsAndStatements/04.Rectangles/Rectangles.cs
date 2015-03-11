using System;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            // Write an expression that calculates rectangle’s perimeter and area by given width and height. 

            Console.Write("width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("height: ");
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            Console.WriteLine("area: " + area);
            double perimeter = 2 * (width + height);
            Console.WriteLine("perimeter: " + perimeter);
        }
    }
}
