using System;

namespace _04.CompanyHierarchy
{
    using Interfaces;

    class Customer : Person, ICustomer
    {
        private double purshaceAmount;

        public double PurshaceAmount
        {
            get { return this.purshaceAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Purshace amount cannot be less than 0.");
                }
                this.purshaceAmount = value;
            }
        }

        public Customer(string id, string firstName, string lastName, 
            double purshaceAmount)
            : base (id, firstName, lastName)
        {
            this.PurshaceAmount = purshaceAmount;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + this.PurshaceAmount;
        }
    }
}
