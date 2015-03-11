namespace _02.BankOfKurtovoKonare
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            Customer vanko = new IndividualCustomer("Vanko");
            Customer kroki = new CompanyCustomer("Kroki");
            Customer valq = new IndividualCustomer("Valq");

            Account vankoAccount = new DepositAccount(vanko, 1450.59, 9);
            Account krokiAccount = new LoanAccount(kroki, 55623.89, 7);
            Account valqAccount = new MortgageAccount(valq, 901.12, 6);

            IList<Account> accounts = new List<Account>
            {
                vankoAccount, valqAccount, krokiAccount
            };

            Bank bank = new Bank("KukuBanka", accounts);

            Console.WriteLine(bank);

            foreach (var account in accounts)
            {
                Console.WriteLine(account.CalculateInterest(12));
            }
        }
    }
}
