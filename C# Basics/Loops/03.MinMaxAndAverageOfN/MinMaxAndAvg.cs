using System;
using System.Linq;

namespace _03.MinMaxAndAverageOfN
{
    class MinMaxAndAvg
    {
        static void Main()
        {
            // Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
            // the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n 
            // (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. 

            Console.Write("sequence size: ");
            int size = int.Parse(Console.ReadLine());
            int[] number = new int[size];
            Console.WriteLine("Values:");
            for (int i = 0; i < size; i++)
			{
                number[i] = int.Parse(Console.ReadLine());
			}

            Console.WriteLine("Min = " + number.Min());
            Console.WriteLine("Max =  " + number.Max());
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Avg = {0:0.00}", (double)(sum / 2.00));
        }
    }
}
