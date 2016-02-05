namespace BookShop.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<BookShopContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
            this.ContextKey = "BookShop.Data.BookShopModel";
        }
    }
}
