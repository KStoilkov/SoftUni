using System;

namespace _06.Calculate2
{
    class Calculate2
    {
        static void Main()
        {
            // Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int nFak = 1;
            int kFak = 1;
            int counter = 1;

            while (1 < k && k < n && n < 100)
            {
                if (counter <= n)
                {
                    nFak *= counter;
                }
                if (counter <= k)
                {
                    kFak *= counter;
                }
                if (counter >= n && counter >= k)
                {
                    break;
                }
                counter++;
                
            }
            Console.WriteLine(nFak / kFak);
        }
    }
}
