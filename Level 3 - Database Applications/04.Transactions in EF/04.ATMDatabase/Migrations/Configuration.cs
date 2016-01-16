namespace _04.ATMDatabase.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ATMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "_04.ATMDatabase.ATMContext";
        }

        protected override void Seed(ATMContext context)
        {
            if (!context.CardAccounts.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    context.CardAccounts.Add(new CardAccount
                    {
                        CardNumber = $"N{i}{i+1}{i+2}",
                        CardPIN = $"{i}{i}{i}{i}",
                        CardCash = i * 20 + (100 * i)
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
