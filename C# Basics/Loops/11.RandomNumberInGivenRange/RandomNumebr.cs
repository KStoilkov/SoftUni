using System;

namespace _11.RandomNumberInGivenRange
{
    class RandomNumebr
    {
        static void Main()
        {
            // Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max: ");
            int max = int.Parse(Console.ReadLine());

            while (min >= max)
            {
                Console.Write("min: ");
                min = int.Parse(Console.ReadLine());
                Console.Write("max: ");
                max = int.Parse(Console.ReadLine());
            }

            Random generator = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(generator.Next(min, max));
            }
        }
    }
}
