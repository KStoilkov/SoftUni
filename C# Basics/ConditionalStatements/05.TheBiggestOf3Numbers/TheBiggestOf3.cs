using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheBiggestOf3Numbers
{
    class TheBiggestOf3
    {
        static void Main()
        {
            // Write a program that finds the biggest of three numbers. 

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("biggest: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("biggest: " + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("biggest: " + c);
            }
            else
            {
                Console.WriteLine("biggest: 0" );
            }
        }
    }
}
