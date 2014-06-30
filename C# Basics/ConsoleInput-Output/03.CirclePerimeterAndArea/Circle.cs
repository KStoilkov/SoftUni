using System;

namespace _03.CirclePerimeterAndArea
{
    class Circle
    {
        static void Main(string[] args)
        {
            // Write a program that reads the radius r of a circle and prints its perimeter and area 
            // formatted with 2 digits after the decimal point.

            Console.Write("r: ");
            double r = double.Parse(Console.ReadLine());

            double p = Math.PI;
            double area = p * Math.Pow(r, 2);
            double perimeter = 2 * p * r;

            Console.WriteLine("perimeter: {0, 10:F2}", perimeter);
            Console.WriteLine("area: {0, 15:F2}",area);
        }
    }
}
