namespace _04.ATMDatabase
{
    using System.Linq;

    public class ATMDatabaseMain
    {
        static void Main()
        {
            var context = new ATMContext();
            var cardAccountsCount = context.CardAccounts.Count();
        }
    }
}
