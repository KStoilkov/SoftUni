namespace _01.NewsDatabase.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NewsContext context)
        {
            if (!context.News.Any())
            {
                for (int i = 0; i < 20; i++)
                {
                    context.News.Add(new News
                    {
                        Content = "Content N" + i
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
