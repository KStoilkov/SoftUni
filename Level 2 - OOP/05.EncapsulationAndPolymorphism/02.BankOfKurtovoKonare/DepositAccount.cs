namespace _02.BankOfKurtovoKonare
{
    using Interfaces;

    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(Customer customer, double balance, int interestRate)
            : base(customer, balance, interestRate)
        {
            
        }

        public void Withdraw(double withdrawAmount)
        {
            this.Balance -= withdrawAmount;
        }

        public override double CalculateInterest(int month)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return this.Balance * (1 + this.InterestRate * month);
        }
    }
}
