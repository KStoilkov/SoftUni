using System;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            // Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
            // Use the Euclidean algorithm (find it in Internet). 

            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            if (b > a)
            {
                a = a ^ b;
                b = b ^ a;
                a = b ^ a;
            }

            while (true)
            {

                int reminder = a % b;
                if (reminder == 0)
                {
                    Console.WriteLine("GCD: " + b);
                    break;
                }
                else
                {
                    a = b;
                    b = reminder;
                }
            }
        }
    }
}
