using System;

namespace _11.Numbers_in_interval_dividable_by_given_number
{
    class Program
    {
        static void Main()
        {
            // Write a program that reads two positive integer numbers and prints how many numbers p exist between them such
            // that the reminder of the division by 5 is 0. 

            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            int p = 0;
            int comments = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5== 0)
                {
                    Console.WriteLine(i);
                    p += 1;
                }
            }
            Console.WriteLine("p: " + p);
        }
    }
}
