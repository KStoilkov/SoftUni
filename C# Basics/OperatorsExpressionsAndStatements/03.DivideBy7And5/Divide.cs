using System;

namespace _03.DivideBy7And5
{
    class Divide
    {
        static void Main()
        {
            // Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool divider = number % 5 == 0 && number % 7 == 0;

            Console.WriteLine(divider);
            Console.WriteLine();
        }
    }
}
