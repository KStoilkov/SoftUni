using System;

namespace _02.FractionCalculator
{
    class Test
    {
        static void Main()
        {
            Fraction f1 = new Fraction(22, 7);
            Fraction f2 = new Fraction(40, 4);
            Fraction sumFraction = f1 + f2;
            Fraction subFraction = f2 - f1;

            Console.WriteLine(sumFraction);
            Console.WriteLine(subFraction);
        }
    }
}
