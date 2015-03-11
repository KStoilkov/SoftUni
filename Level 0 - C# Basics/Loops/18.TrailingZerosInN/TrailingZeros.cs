using System;

namespace _18.TrailingZerosInN
{
    class TrailingZeros
    {
        static void Main()
        {
            //Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
            // Your program should work well for very big numbers, e.g. n=100000. 

            Console.Write("n: ");
            ulong n = ulong.Parse(Console.ReadLine());

            ulong fak = 1;

            for (ulong i = n; i > 0; i--)
            {
                fak *= i;
            }

            int[] fakHolder = Array.ConvertAll<string, int>
                (System.Text.RegularExpressions.Regex.Split(fak.ToString(),
                @"(?!^)(?!$)"), str => int.Parse(str));
            
            int zeroCounter = 0;

            for (int i = fakHolder.Length - 1; i >= 0; i--)
            {
                if (fakHolder[i] == 0)
                {
                    zeroCounter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("zeros: " + zeroCounter);
        }
    }
}
