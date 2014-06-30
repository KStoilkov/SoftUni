using System;

namespace _09.SumOfNNumbers
{
    class SumNNumbers
    {
        static void Main()
        {
            // Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
            // Note that you may need to use a for-loop. 

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("sum: " + sum);
        }
    }
}
