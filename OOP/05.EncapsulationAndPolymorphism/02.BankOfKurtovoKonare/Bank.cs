namespace _02.BankOfKurtovoKonare
{
    using System.Text;
    using System.Collections.Generic;

    public class Bank
    {
        public string Name { get; set; }

        public IList<Account> Accounts { get; set; }

        public Bank(string name, IList<Account> accounts)
        {
            this.Name = name;
            this.Accounts = accounts;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.Name);

            foreach (var account in Accounts)
            {
                result.AppendLine(account.ToString());
            }

            return result.ToString();
        }
    }
}
