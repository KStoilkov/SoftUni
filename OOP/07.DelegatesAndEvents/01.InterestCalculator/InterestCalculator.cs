namespace _01.InterestCalculator
{
    using System;

    public class InterestCalculator
    {
        private double sum;
        
        private double interest;

        private int years;


        public InterestCalculator(
            double sum, double interest, int years, CalculateInterest calculateMethod)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.CalculatedInterest = calculateMethod(this.Sum, this.Interest, this.Years);
        }


        public double Sum
        {
            get
            {
                return this.sum;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Sum cannot be less than 0.");
                }

                this.sum = value;
            }
        }

        public double Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be less than 0.");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Years cannot be less than 0.");
                }

                this.years = value;
            }
        }

        public string CalculatedInterest { get; private set; }
    }
}
