namespace News.RepositoriesTests
{
    using Data;
    using Data.Repositories;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Transactions;

    [TestClass]
    public class NewsTests
    {
        private TransactionScope tran;
        private NewsRepository repo;

        [TestInitialize]
        public void Initiaize()
        {
            this.tran = new TransactionScope();
            this.repo = new NewsRepository(new NewsContext());
        }

        [TestCleanup]
        public void Clean()
        {
            this.tran.Dispose();
        }

        [TestMethod]
        public void GetAllNewsShouldReturnTheNewsCorrectly()
        {
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

            List<NewsModel> testList = new List<NewsModel>()
            {
                news,
                news1
            };

            this.repo.Add(news);
            this.repo.Add(news1);
            this.repo.SaveChanges();

            var newsInDb = this.repo.All().ToList();

            CollectionAssert.AreEqual(testList, newsInDb);
        }

        [TestMethod]
        public void CreateNewsWithCorrectDataShouldCreateAndReturnNews()
        {
            var news = new NewsModel
            {
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            var newsInDb = this.repo.Add(news);

            Assert.IsNotNull(newsInDb);
            Assert.AreEqual(news.Title, newsInDb.Title);
            Assert.AreEqual(news.Content, newsInDb.Content);
            Assert.AreEqual(news.PublishDate, newsInDb.PublishDate);
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void CreateNewsWithIncorrectDataShouldThrowException()
        {
            var news = new NewsModel
            {
                Title = "1",
                Content = "2",
                PublishDate = DateTime.Now
            };

            this.repo.Add(news);
            this.repo.SaveChanges();
        }

        [TestMethod]
        public void ModifyItemWithCorrectDataShouldModifyCorrectly()
        {
            var news = new NewsModel
            {
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            this.repo.Add(news);
            this.repo.SaveChanges();

            var newNews = new NewsModel
            {
                Title = "Fire was extinguished",
                Content = "No more fire.",
                PublishDate = DateTime.Now
            };

            var newsInDb = this.repo.Find(news.Id);
            newsInDb.Title = newNews.Title;
            newsInDb.Content = newNews.Content;
            newsInDb.PublishDate = newNews.PublishDate;

            this.repo.Update(newsInDb);
            this.repo.SaveChanges();

            var updatedNewsInDb = this.repo.Find(newsInDb.Id);

            Assert.AreEqual(newNews.Title, updatedNewsInDb.Title);
            Assert.AreEqual(newNews.Content, updatedNewsInDb.Content);
            Assert.AreEqual(newNews.PublishDate, updatedNewsInDb.PublishDate);
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void ModifyItemWithIncorrectDataShouldThrowException()
        {
            var news = new NewsModel
            {
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            this.repo.Add(news);
            this.repo.SaveChanges();

            news.Content = "0";

            this.repo.Update(news);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ModifyNonExistingItemShouldThrowEsception()
        {
            var news = new NewsModel
            {
                Id = 1895,
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            this.repo.Update(news);
            this.repo.SaveChanges();        
        }

        [TestMethod]
        public void DeleteExistingItemShouldDeleteItem()
        {
            var news = new NewsModel
            {
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            var n = this.repo.Add(news);
            this.repo.SaveChanges();

            this.repo.Delete(n);
            this.repo.SaveChanges();

            int newsCount = this.repo.All().Count();

            Assert.AreEqual(0, newsCount);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DeleteNonExistingItemShouldThrowException()
        {
            var news = new NewsModel
            {
                Id = 1233,
                Title = "Fire in the motel",
                Content = "The fire fighters are doing their best.",
                PublishDate = DateTime.Now
            };

            this.repo.Delete(news);
            this.repo.SaveChanges();
        }
    }
}
