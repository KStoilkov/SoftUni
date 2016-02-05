namespace BookShop.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;
    using Models;
    using System.Data.Entity;

    public class BookShopContext : IdentityDbContext<ApplicationUser>
    {
        public BookShopContext()
            : base("name=BookShopModel")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<BookShopContext, Configuration>());
        }

        public IDbSet<Author> Authors { get; set; }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Purshase> Purshases { get; set; }

        public static BookShopContext Create()
        {
            return new BookShopContext();
        }
    }
}