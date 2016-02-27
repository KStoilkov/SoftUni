namespace News.Services.Controllers
{
    using Data;
    using Data.Repositories;
    using Models;
    using News.Models;
    using System;
    using System.Web.Http;

    [RoutePrefix("api/News")]
    public class NewsController : ApiController
    {
        private IRepository<NewsModel> repo;
        
        public NewsController(IRepository<NewsModel> repository)
        {
            this.repo = repository;
        }
        
        public NewsController() 
            : this(new NewsRepository(new NewsContext()))
        {
        }

        [HttpGet]
        public IHttpActionResult GetNews()
        {
            var news = this.repo.All();

            return this.Ok(news);
        }

        [HttpPost]
        public IHttpActionResult CreateNews(NewsBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var news = new NewsModel
            {
                Title = model.Title,
                Content = model.Content,
                PublishDate = DateTime.Now
            };

            this.repo.Add(news);
            this.repo.SaveChanges();

            return this.Created($"api/News/{news.Id}", news);
        }

        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult UpdateNews(int id, NewsBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newsInDb = this.repo.Find(id);
            if (newsInDb == null)
            {
                return this.BadRequest($"News with id {id} doesn't exists.");
            }

            newsInDb.Title = model.Title;
            newsInDb.Content = model.Content;
            this.repo.SaveChanges();

            return this.Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult DeleteNews(int id)
        {
            var newsInDb = this.repo.Find(id);
            if (newsInDb == null)
            {
                return this.BadRequest($"News wih id {id} doesn't exists.");
            }

            this.repo.Delete(newsInDb);
            this.repo.SaveChanges();

            return this.Ok();
        }
    }
}
