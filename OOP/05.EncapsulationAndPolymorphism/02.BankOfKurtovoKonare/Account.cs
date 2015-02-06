namespace _02.BankOfKurtovoKonare
{
    using System;
    using Interfaces;

    public abstract class Account : IDeposit
    {
        private double balance;
        private int interestRate;

        public Customer Customer { get; set; }

        public double Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be less than 0.");
                }
                this.balance = value;
            }
        }

        public int InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest Rate cannot be less than 0.");
                }
                this.interestRate = value;
            }
        }

        protected Account(Customer customer, double balance, int interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public abstract double CalculateInterest(int month);

        public void Deposit(double depositAmount)
        {
            this.Balance += depositAmount;
        }

        public override string ToString()
        {
            return "Customer: " + this.Customer + ", Balance: " +
                   this.Balance + ", Interest Rate: " + this.InterestRate;
        }
    }
}
