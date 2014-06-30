using System;

namespace _01.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            // Write a program that reads 3 real numbers from the console and prints their sum.

            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("sum: " + (a + b + c));

        }
    }
}
