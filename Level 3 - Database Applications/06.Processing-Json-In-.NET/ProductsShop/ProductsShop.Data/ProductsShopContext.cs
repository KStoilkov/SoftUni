namespace ProductsShop.Data
{
    using Migrations;
    using Models;
    using System.Data.Entity;

    public class ProductsShopContext : DbContext
    {
        public ProductsShopContext()
            : base("name=ProductsShopContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductsShopContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Friends)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("UserId");
                    m.MapRightKey("FriendId");
                    m.ToTable("UserFriends");
                });

            modelBuilder.Entity<Product>()
                .HasOptional(p => p.Buyer)
                .WithMany(b => b.ProductsBuyed)
                .HasForeignKey(p => p.BuyerId);

            modelBuilder.Entity<Product>()
                .HasRequired(p => p.Seller)
                .WithMany(s => s.ProductsSold)
                .HasForeignKey(p => p.SellerId);

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<User> Users { get; set; }
        public IDbSet<Product> Products { get; set; }
    }
}