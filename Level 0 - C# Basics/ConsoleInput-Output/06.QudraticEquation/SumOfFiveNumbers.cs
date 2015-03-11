using System;

namespace _06.QudraticEquation
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
            // Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
            // (prints its real roots). 

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            while (a == 0)
            {
                Console.Write("a ( != 0 ): ");
                a = double.Parse(Console.ReadLine());
            }
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - (4 * a * c);

            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

                if (discriminant == 0)
                {
                    Console.WriteLine("x1=x2={0}", x1);
                }
                else
                {
                    Console.WriteLine("x1={0:0.###}; x2={1:0.###}", x1, x2);
                }
            }
        }
    }
}
