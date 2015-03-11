using System;

namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            // Write an if-statement that takes two integer variables a and b and exchanges their values if the first one 
            // is greater than the second one. As a result print the values a and b, separated by a space.

            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            if (b > a)
            {
                Console.WriteLine(b + " " + a);
            }
            else
            {
                Console.WriteLine(a + " " + b);
            }
        }
    }
}
