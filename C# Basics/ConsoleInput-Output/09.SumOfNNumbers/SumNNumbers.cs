using System;

namespace _09.SumOfNNumbers
{
    class SumNNumbers
    {
        static void Main()
        {
            // Write a program that enters a number n and after that enters more n numbers and calculates and prdoubles their sum. 
            // Note that you may need to use a for-loop. 

            Console.Write("n: ");
            double n = double.Parse(Console.ReadLine());
            double sum = 0.00;
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("sum: " + sum);
        }
    }
}
