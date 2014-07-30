using System;

namespace _02.NumbersNotDivisibleBy3And7
{
    class NotDivisible
    {
        static void Main()
        {
            // Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7,
            // on a single line, separated by a space.

            int n = 0;
            while (n < 1)
            {
                Console.Write("Enter a positive integer: ");
                n = int.Parse(Console.ReadLine());
            }
            

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0|| i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
        }
    }
}
