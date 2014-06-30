using System;

namespace _10.FibonacciNumbers
{
    class Fibonacci
    {
        static void Main()
        {
            // Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
            // (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
            // Note that you may need to learn how to use loops. 

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;
            Console.Write("0 1 ");
            for (int i = 0; i <= n; i++)
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                Console.Write(" "+ n3 + " ");
            }
            Console.WriteLine();
        }
    }
}
