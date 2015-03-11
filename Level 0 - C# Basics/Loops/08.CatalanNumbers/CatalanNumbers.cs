using System;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            // Write a program to calculate the nth Catalan number by given n (1 < n < 100).

            int n = int.Parse(Console.ReadLine());

            while (1 >= n && n >= 100)
            {
                n = int.Parse(Console.ReadLine());
            }

            int faktoN = 1;

            for (int i = 2*n; i > n + 1; i--)
            {
                faktoN *= i;
            }

            int fakN = 1;

            for (int i = 2; i <= n; i++)
            {
                fakN *= i;
            }

            int catalan = faktoN / fakN;
            Console.WriteLine("Catalan number: " + catalan);
        }
    }
}
