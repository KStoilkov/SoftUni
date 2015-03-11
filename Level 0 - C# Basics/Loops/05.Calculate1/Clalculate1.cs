using System;

namespace _05.Calculate1
{
    class Clalculate1
    {
        static void Main()
        {
            // Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
            // Use only one loop. Print the result with 5 digits after the decimal point.

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            double sum = 1;
            double fak = 1;
            double pow = 1;

            for (int i = 1; i < n; i++)
            {
                fak *= i;
                pow *= x;
                sum += (fak / pow);
            }
            Console.WriteLine("sum: {0:F5}",sum);
        }
    }
}
