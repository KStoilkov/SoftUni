using System;

namespace _11.BitwiseExtractBit3
{
    class Bitwise
    {
        static void Main()
        {
            // Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
            // The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 

            Console.Write("n: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("binary: " + Convert.ToString(n, 2));

            int position = 3;
            int mask = 1;

            int bit = (int)(n >> position) & mask;
            Console.WriteLine("bit#3: " + bit);
            Console.WriteLine();
        }
    }
}