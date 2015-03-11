using System;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            // Write an expression that extracts from given integer n the value of given bit at index p.

            Console.Write("number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("binary: " + Convert.ToString(n, 2));
            Console.Write("position: ");
            int p = int.Parse(Console.ReadLine());

            int mask = 1;
            int bit = (n >> p) & mask;
            Console.WriteLine(bit);
        }
    }
}
