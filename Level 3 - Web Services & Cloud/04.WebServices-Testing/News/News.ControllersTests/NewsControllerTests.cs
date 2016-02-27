namespace News.ControllersTests
{
    using Data.Repositories;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;
    using Models;
    using Services.Controllers;
    using Services.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Web.Http;

    [TestClass]
    public class NewsControllerTests
    {
        private IRepository<NewsModel> context;

        [TestInitialize]
        public void Initialize()
        {
            this.context = new NewsRepositoryMock();
        }

        [TestMethod]
        public void ListAllNews_ShouldReturnNewsCorrectly()
        {
            var controller = new NewsController(this.context);
            this.SetupController(controller);

            var news = new NewsModel
            {
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            var news1 = new NewsModel
            {
                Title = "Untitled",
                Content = "No content",
                PublishDate = new DateTime(1995, 10, 5)
            };

            var news2 = new NewsModel
            {
                Title = "Today hits",
                Content = "No content",
                PublishDate = DateTime.Now
            };

            this.context.Add(news);
            this.context.Add(news1);
            this.context.Add(news2);

            var response = controller.GetNews().ExecuteAsync(CancellationToken.None).Result;

            var newsResponce = response.Content
                .ReadAsAsync<IEnumerable<NewsModel>>()
                .Result
                .ToList();

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            CollectionAssert.AreEqual(newsResponce, this.context.All().ToList());
        }

        [TestMethod]
        public void CreatingItem_ShouldCreateTheItemAndReturnIt()
        {
            var controller = new NewsController(this.context);
            this.SetupController(controller);
            
            var newsBindingModel = new NewsBindingModel
            {
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best."
            };

            var response = controller.CreateNews(newsBindingModel).ExecuteAsync(CancellationToken.None).Result;

            var responseNews = response.Content.ReadAsAsync<NewsBindingModel>().Result;

            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            Assert.AreEqual(newsBindingModel.Title, responseNews.Title);
            Assert.AreEqual(newsBindingModel.Content, responseNews.Content);
        }

        [TestMethod]
        public void CreatingItemWithIncorrectData_ShouldReturnBadRequest()
        {
            var controller = new NewsController(this.context);
            this.SetupController(controller);

            // Forcing validation error
            controller.ModelState.AddModelError("Title", "Title should be atleast 3 symbols.");

            var newsBindingModel = new NewsBindingModel
            {
                Title = "1",
                Content = "2222"
            };
            
            var response = controller.CreateNews(newsBindingModel).ExecuteAsync(CancellationToken.None).Result;

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [TestMethod]
        public void ModifyExistingNewsItemWithCorrectData_ShouldModifyTheNewsItem()
        {
            var controller = new NewsController(this.context);
            this.SetupController(controller);

            var news = new NewsModel
            {
                Id = 555,
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            var modifiedNews = new NewsBindingModel
            {
                Title = "Random title",
                Content = "Random Content"
            };

            this.context.Add(news);

            var response = controller.UpdateNews(555, modifiedNews).ExecuteAsync(CancellationToken.None).Result;
            var newsInDb = controller.GetNews().ExecuteAsync(CancellationToken.None).Result
                .Content.ReadAsAsync<IEnumerable<NewsModel>>().Result
                .FirstOrDefault(n => n.Id == news.Id);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(modifiedNews.Title, newsInDb.Title);
            Assert.AreEqual(modifiedNews.Content, newsInDb.Content);
        }

        [TestMethod]
        public void ModifyExistingNewsItemWithIncorrectData_ShouldReturnBadRequest()
        {
            var controller = new NewsController(this.context);
            this.SetupController(controller);

            // Forcing validation error
            controller.ModelState.AddModelError("Title", "Title should be atleast 3 symbols.");

            var news = new NewsModel
            {
                Id = 101,
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            var modifiedNews = new NewsBindingModel
            {
                Title = "1",
                Content = "222"
            };

            this.context.Add(news);

            var response = controller.UpdateNews(101, modifiedNews).ExecuteAsync(CancellationToken.None).Result;

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [TestMethod]
        public void ModifyNonExistingNewsItem_ShouldReturnBadRequest()
        {
            var controller = new NewsController(this.context);
            this.SetupController(controller);

            var modifiedNews = new NewsBindingModel
            {
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best."
            };

            var response = controller.UpdateNews(1895, modifiedNews).ExecuteAsync(CancellationToken.None).Result;

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [TestMethod]
        public void DeleteExistingItem_ShouldDeleteTheItem()
        {
            var controller = new NewsController(this.context);
            this.SetupController(controller);

            var news = new NewsModel
            {
                Id = 101,
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            this.context.Add(news);

            var response = controller.DeleteNews(news.Id).ExecuteAsync(CancellationToken.None).Result;

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void DeleteUnexistingNewsItem_ShouldReturnBadRequest()
        {
            var controller = new NewsController(this.context);
            this.SetupController(controller);
            
            var response = controller.DeleteNews(2895).ExecuteAsync(CancellationToken.None).Result;

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }

        private void SetupController(NewsController newsController)
        {
            newsController.Request = new HttpRequestMessage();
            newsController.Configuration = new HttpConfiguration();
        }
    }
}
