namespace _05.TransactionalATMWithdrawal
{
    using _04.ATMDatabase;
    using System;
    using System.Linq;
    public class WithdrawMain
    {
        static void Main()
        {
            var context = new ATMContext();

            using (var dbContextTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    Console.Write("Card Number: ");
                    string cardNumber = Console.ReadLine();

                    var cardAccount = context.CardAccounts
                        .FirstOrDefault(c => c.CardNumber == cardNumber);

                    if (cardAccount == null)
                    {
                        throw new InvalidOperationException($"Account with card number: {cardNumber} doesn't exist");
                    }

                    Console.Write("Card Pin: ");
                    string cardPin = Console.ReadLine();

                    if (cardAccount.CardPIN != cardPin)
                    {
                        throw new InvalidOperationException("Wrong Pin.");
                    }

                    Console.Write("Withdraw amount: ");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                    if (cardAccount.CardCash < withdrawAmount)
                    {
                        throw new InvalidOperationException("Not enough money.");
                    }
                    else
                    {
                        cardAccount.CardCash -= withdrawAmount;
                    }

                    dbContextTransaction.Commit();

                    context.TransactionHistory.Add(new TransactionHistory
                    {
                        CardNumber = cardNumber,
                        TransactionDate = DateTime.Now,
                        WithdrawAmount = withdrawAmount
                    });
                    
                    context.SaveChanges();

                    Console.WriteLine($"Succesfully withdrawed {withdrawAmount}, current amount {cardAccount.CardCash:0.00}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    dbContextTransaction.Rollback();
                }
            }
        }
    }
}
