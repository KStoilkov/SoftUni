namespace _02.FractionCalculator
{
    public struct Fraction
    {
        public int Numerator { get; set; }

        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            if (f1.Denominator == f2.Denominator)
            {
                return new Fraction(f1.Numerator + f2.Numerator, f1.Denominator);
            }

            int resultDenominator = f1.Denominator * f2.Denominator;
            int resultNumerator = f1.Numerator * f2.Denominator;
            resultNumerator += f2.Numerator * f1.Denominator;

            return new Fraction(resultNumerator, resultDenominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            if (f1.Denominator == f2.Denominator)
            {
                return new Fraction(f1.Numerator - f2.Numerator, f1.Denominator);
            }

            int resultDenominator = f1.Denominator * f2.Denominator;
            int resultNumerator = f1.Numerator * f2.Denominator;
            resultNumerator -= f2.Numerator * f1.Denominator;

            return new Fraction(resultNumerator, resultDenominator);
        }

        public override string ToString()
        {
            return ((double)this.Numerator / (double)this.Denominator).ToString();
        }
    }
}
