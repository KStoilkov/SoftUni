using System;

namespace _07.Calculate3
{
    class Program
    {
        static void Main()
        {
            // In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations)
            // is calculated by the following formula:
            // For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
            // Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
            // Try to use only two loops. 

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int ntokFak = 1;
            int nkFak = n - k;
            

            for (int i = n; i > k; i--)
            {
                ntokFak *= i;
            }
            

            for (int i = 2; i <= n - k; i++)
            {
                nkFak *= i;
            }
            
            Console.WriteLine(ntokFak / nkFak);
        }
    }
}