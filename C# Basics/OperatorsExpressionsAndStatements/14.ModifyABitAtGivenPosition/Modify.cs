using System;

namespace _14.ModifyABitAtGivenPosition
{
    class Modify
    {
        static void Main()
        {
            // We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators 
            // (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation 
            // of n while preserving all other bits in n. 

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("binary: " + Convert.ToString(n, 2));
            Console.Write("p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("v[0/1]: ");
            int v = int.Parse(Console.ReadLine());
           
            int modifyBit;
            int mask;

            if (v == 0)
            {
                mask = ~(1 << p);
                modifyBit = n & mask;
                Console.WriteLine("binary result: " + Convert.ToString(modifyBit, 2));
                Console.WriteLine("result: " + modifyBit);
                Console.WriteLine();
            }
            else if (v == 1)
            {
                mask = 1 << p;
                modifyBit = n | mask;
                Console.WriteLine("binary result: " + Convert.ToString(modifyBit, 2));
                Console.WriteLine("result: " + modifyBit);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The value must be 0 or 1");
                Console.WriteLine();
            }
        }
    }
}
