using System;

namespace _06.Four_DigitNumber
{
    class FourDigit
    {
        static void Main()
        {
            //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            //  •	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            //  •	Prints on the console the number in reversed order: dcba (in our example 1102).
            //  •	Puts the last digit in the first position: dabc (in our example 1201).
            //  •	Exchanges the second and the third digits: acbd (in our example 2101).

            Console.Write("Enter a four digit number: ");
            int number = int.Parse(Console.ReadLine());

            int a = number / 1000;
            a %= 10;

            int b = number / 100;
            b %= 10;

            int c = number / 10;
            c %= 10;

            int d = number % 10;

            int sum = a + b + c + d;
            Console.WriteLine("Sum of the Digits: " + sum);
            Console.WriteLine("Reverse order: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit at first position: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Exchange second and third digits: {0}{1}{2}{3}", a, c, b, d);
            Console.WriteLine();
        }
    }
}
