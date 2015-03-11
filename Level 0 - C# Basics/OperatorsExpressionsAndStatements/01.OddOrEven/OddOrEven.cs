using System;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            // Write an expression that checks if given integer is odd or even. 

            int number = int.Parse(Console.ReadLine());
            bool OddNumber = number % 2 == 1;
            Console.WriteLine(OddNumber);
            Console.WriteLine();
        }
    }
}
