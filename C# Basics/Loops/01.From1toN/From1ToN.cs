using System;

namespace _01.From1toN
{
    class From1ToN
    {
        static void Main()
        {
            // Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. 

            int n = 0;
            while (n < 1)
            {
                Console.Write("Enter a positive integer: ");
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write( i + " ");
            }
            Console.WriteLine();
        }
    }
}
