namespace OnlineShop.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Migrations;
    using Models;
    using System.Data.Entity;

    public class OnlineShopContext : IdentityDbContext<ApplicationUser>
    {
        public OnlineShopContext()
            : base("name=OnlineShopContext")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<OnlineShopContext, Configuration>());
        }
        
        public IDbSet<Ad> Ads { get; set; }
        public IDbSet<AdType> AdTypes { get; set; }
        public IDbSet<Category> Categories { get; set; }

        public static OnlineShopContext Create()
        {
            return new OnlineShopContext();
        }
    }
}