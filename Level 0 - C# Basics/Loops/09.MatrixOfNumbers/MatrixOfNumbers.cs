using System;

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            // Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
            // and prints a matrix like in the examples below. Use two nested loops. 

            int n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 20)
            {
                n = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                
                for (int j = i; j < n + i; j++)
                {
                    Console.Write("{0, -2} ",j);

                }
                Console.WriteLine();
            }
        }
    }
}
