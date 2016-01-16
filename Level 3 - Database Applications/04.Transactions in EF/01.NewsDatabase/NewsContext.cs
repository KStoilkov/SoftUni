namespace _01.NewsDatabase
{
    using Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NewsContext : DbContext
    {
        public NewsContext()
            : base("name=NewsContext")
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<NewsContext, Configuration>());
        }

        public virtual IDbSet<News> News { get; set; }
    }
}