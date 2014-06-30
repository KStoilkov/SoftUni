using System;
using System.Linq;
using System.Collections.Generic;

namespace _14.SumOfElements
{
    class SumOfElements
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            string[] input = inputLine.Split(' '); 
            long[] numbers = Array.ConvertAll(input, long.Parse); 
            long maxNumber = numbers.Max(); 
            long totalSumOfNumber = numbers.Sum(); 
            long check = totalSumOfNumber - maxNumber; 

            if (check == maxNumber) 
            {
                Console.WriteLine("Yes, sum={0}", check);
            }
            else
            {
                long result = check - maxNumber;
                if (result < 0)
                {
                    Console.WriteLine("No, diff={0}", result * (-1));
                }
                else
                {
                    Console.WriteLine("No, diff={0}", result);
                }
            }
        }
    }
}
