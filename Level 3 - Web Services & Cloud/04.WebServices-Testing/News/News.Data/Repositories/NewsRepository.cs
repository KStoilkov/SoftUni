namespace News.Data.Repositories
{
    using System;
    using System.Linq;
    using Models;
    using System.Data.Entity;

    public class NewsRepository : IRepository<NewsModel>
    {
        private DbContext context;

        public NewsRepository(DbContext context)
        {
            this.context = context;
        }

        public NewsModel Add(NewsModel entity)
        {
            this.context.Set<NewsModel>().Add(entity);
            return entity;
        }

        public IQueryable<NewsModel> All()
        {
            var news = this.context.Set<NewsModel>().ToList().AsQueryable();

            return news;
        }

        public void Delete(NewsModel entity)
        {
            this.context.Set<NewsModel>().Remove(entity);
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public NewsModel Find(object id)
        {
            var news = this.context.Set<NewsModel>().Find(id);

            return news;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public void Update(NewsModel entity)
        {
            var news = this.Find(entity.Id);

            news.Title = entity.Title;
            news.Content = entity.Content;
            news.PublishDate = entity.PublishDate;

            this.SaveChanges();
        }
    }
}
