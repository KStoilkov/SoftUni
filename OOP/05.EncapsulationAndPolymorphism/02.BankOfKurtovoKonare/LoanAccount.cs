namespace _02.BankOfKurtovoKonare
{
    using Interfaces;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, double balance, int interestRate)
            : base (customer, balance, interestRate)
        {
            
        }

        public override double CalculateInterest(int month)
        {
            if (this.Customer is IndividualCustomer)
            {
                return this.Balance * (1 + this.InterestRate * (month - 3));
            }

            return this.Balance * (1 + this.InterestRate * (month - 2));
        }
    }
}
