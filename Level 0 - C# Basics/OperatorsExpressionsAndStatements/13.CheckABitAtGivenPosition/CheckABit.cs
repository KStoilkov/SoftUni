using System;

namespace _13.CheckABitAtGivenPosition
{
    class CheckABit
    {
        static void Main()
        {
            // Write a Boolean expression that returns 
            // if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1.

            Console.Write("number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("binary: " + Convert.ToString(number, 2));
            Console.Write("position: ");
            int p = int.Parse(Console.ReadLine());
            int mask = 1;
            int bit = (number >> p) & mask;

            bool bitAtPosition = false;

            if (bit == 1)
            {
                bitAtPosition = true;
                Console.WriteLine("bit @ p == 1: " + bitAtPosition);
            }
            else
            {
                Console.WriteLine("bit @ p == 1: " + bitAtPosition);
            }
           
        }
    }
}
