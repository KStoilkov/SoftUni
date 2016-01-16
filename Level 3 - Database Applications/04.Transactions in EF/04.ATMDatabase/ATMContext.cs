namespace _04.ATMDatabase
{
    using Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ATMContext : DbContext
    {
        public ATMContext()
            : base("name=ATMContext")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<ATMContext, Configuration>());
        }

        public virtual IDbSet<CardAccount> CardAccounts { get; set; }
        public virtual IDbSet<TransactionHistory> TransactionHistory { get; set; }
    }
}