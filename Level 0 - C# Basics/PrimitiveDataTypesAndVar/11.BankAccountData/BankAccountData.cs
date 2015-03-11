using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            // A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers 
            // associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

            string holderFirstName = "Goshko";
            string holderMiddleName = "Petrov";
            string holderLastName = "Toshkov";
            string holderFullName = holderFirstName + " " + holderMiddleName + " " + holderLastName;
            float balance = 1450.25F;
            string bankName = "GoshkoBank";
            string IBAN = "BG345GOSHKO7HSD0962H22";
            long creditCard1 = 1123456789012345;
            long creditCard2 = 1234567890123456;
            long creditCard3 = 2345678901234567;

            Console.WriteLine(bankName + " " + "Card Holder Information: ");
            Console.WriteLine();
            Console.WriteLine("Name: " + holderFullName);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("IBAN: " + IBAN);
            Console.WriteLine("Credit cards: ");
            Console.WriteLine(" " + "1. " + creditCard1);
            Console.WriteLine(" " + "2. " + creditCard2);
            Console.WriteLine(" " + "3. " + creditCard3);
            Console.WriteLine();


        }
    }
}
