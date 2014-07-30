using System;
using System.Linq;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            // You are given n integers (given in a single line, separated by a space). 
            // Write a program that checks whether the product of the odd elements is equal to the product of the even elements. 
            // Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 

            string input = Console.ReadLine();
            int[] inputed = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            int evenProduct = 1;
            int oddProduct = 1;

            for (int i = 0; i < inputed.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= inputed[i];
                }
                else if (i % 2 == 1)
                {                  
                    evenProduct *= inputed[i];
                }
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + evenProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = " + oddProduct);
                Console.WriteLine("even_product = " + evenProduct);
            }
        }
    }   
}
