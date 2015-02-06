namespace _02.BankOfKurtovoKonare
{
    using Interfaces;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, double balance, int interestRate)
            : base (customer, balance, interestRate)
        {
            
        }

        public override double CalculateInterest(int month)
        {
            return this.Balance * (1 + this.InterestRate * (month - 6));
        }
    }
}
