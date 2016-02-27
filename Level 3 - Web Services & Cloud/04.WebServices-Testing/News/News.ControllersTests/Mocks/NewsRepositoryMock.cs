namespace News.ControllersTests.Mocks
{
    using System.Linq;
    using Data.Repositories;
    using Models;
    using System.Collections.Generic;

    public class NewsRepositoryMock : IRepository<NewsModel>
    {
        private List<NewsModel> Context { get; set; }

        public NewsRepositoryMock()
        {
            this.Context = new List<NewsModel>();
        }

        public NewsModel Add(NewsModel entity)
        {
            this.Context.Add(entity);
            return entity;
        }

        public IQueryable<NewsModel> All()
        {
            return this.Context.AsQueryable();
        }

        public void Delete(NewsModel entity)
        {
            this.Context.Remove(entity);
        }

        public void Dispose()
        {
            this.Context = null;
        }

        public NewsModel Find(object id)
        {
            return this.Context.FirstOrDefault(n => n.Id == (int)id);
        }

        public void SaveChanges()
        {
            return;
        }

        public void Update(NewsModel entity)
        {
            var news = this.Context.FirstOrDefault(n => n.Id == entity.Id);

            news.Title = entity.Title;
            news.Content = entity.Content;
            news.PublishDate = entity.PublishDate;
        }
    }
}
