namespace _01.InterestCalculator
{
    using System;

    public class Test
    {
        public static void Main()
        {

            CalculateInterest simple = GetSimpleInterest;
            CalculateInterest compound = GetCompundInterest;

            InterestCalculator calc = new InterestCalculator(500, 5.6, 10, compound);
            InterestCalculator calc2 = new InterestCalculator(2500, 7.2, 15, simple);

            Console.WriteLine(calc.CalculatedInterest);
            Console.WriteLine(calc2.CalculatedInterest);
        }

        public static string GetSimpleInterest(double sum, double interest, int years)
        {
            double result = sum * (1 + (interest / 100) * years);
            return result.ToString("F4");
        }

        public static string GetCompundInterest(double sum, double interest, int years)
        {
            double result = sum * (Math.Pow(1 + (interest / 100) / 12, years * 12));
            return result.ToString("F4");
        }
    }
}
