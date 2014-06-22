using System;

namespace _05.ThirdDigitIs7
{
    class ThirdDigit
    {
        static void Main()
        {
            // Write an expression that checks for given integer if its third digit from right-to-left is 7.

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            number /= 100;
            bool thirdDigit = number % 10 == 7;
            Console.WriteLine(thirdDigit);
            Console.WriteLine();
            
        }
    }
}
