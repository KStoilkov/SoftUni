namespace BookShop.Services.Controllers
{
    using System.Web.Http;
    using BookShop.Data;
    using Models;
    using System.Linq;
    using System.Data.Entity.Migrations;
    using BookShop.Models;
    using System;
    using System.Web.OData;
    using Microsoft.AspNet.Identity;

    [RoutePrefix("api/books")]
    public class BooksController : ApiController
    {
        private BookShopContext context;

        public BooksController()
        {
            this.context = new BookShopContext();
        }
        
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetBook(int id)
        {
            var book = context.Books.Find(id);

            if (book == null)
            {
                return this.BadRequest("Book doesn't exist.");
            }

            var viewBook = new GetBookViewModel()
            {
                Title = book.Title,
                Description = book.Description,
                Price = book.Price,
                Copies = book.Copies,
                AuthorId = book.AuthorId,
                AuthorName = book.Author.FirstName,
                Edition = book.Edition,
                Categories = book.Categories.Select(c => c.Name)
            };
            
            return this.Ok(viewBook);
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<SearchBookViewModel> SearchBooks([FromUri]string search)
        {
            var books = context.Books
                .Where(b => b.Title.Contains(search))
                .OrderBy(b => b.Title)
                .Take(10)
                .Select(b => new SearchBookViewModel()
                {
                    Id = b.Id,
                    Title = b.Title
                });
            
            return books;
        }

        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult PutBook(int id, [FromUri]PutBookBindingModel bookModel)
        {
            var book = context.Books.Find(id);

            if (book == null)
            {
                return this.BadRequest("Book doesn't exist");
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var author = context.Authors.FirstOrDefault(a => a.Id == bookModel.AuthorId);

            if (author == null)
            {
                return this.BadRequest("Author doesn't exist in the provided book.");
            }

            book.Title = bookModel.Title;
            book.Description = bookModel.Description;
            book.Price = bookModel.Price;
            book.Copies = bookModel.Copies;
            book.Edition = bookModel.Edition;
            book.AuthorId = bookModel.AuthorId;

            context.Books.AddOrUpdate(book);
            context.SaveChanges();

            var viewBook = new GetBookViewModel()
            {
                Title = book.Title,
                Description = book.Description,
                Price = book.Price,
                Copies = book.Copies,
                AuthorId = book.AuthorId,
                AuthorName = book.Author.FirstName,
                Edition = book.Edition,
                Categories = book.Categories.Select(c => c.Name)
            };

            return this.Ok(viewBook);
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult DeleteBook(int id)
        {
            var book = context.Books.Find(id);

            if (book == null)
            {
                return this.BadRequest("Book doesn't exist.");
            }

            context.Books.Remove(book);
            context.SaveChanges();

            return this.Ok("Book deleted successfully.");
        }

        [HttpPost]
        public IHttpActionResult PostBook([FromUri]PostBookBindingModel bookModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var book = new Book()
            {
                Title = bookModel.Title,
                Description = bookModel.Description,
                Price = bookModel.Price,
                Copies = bookModel.Copies,
                AuthorId = bookModel.AuthorId,
                Edition = bookModel.Edition
            };
            
            string[] stringCategories = bookModel.Categories.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var categoryName in stringCategories)
            {
                var category = context.Categories
                    .FirstOrDefault(c => c.Name == categoryName);

                if (category == null)
                {
                    var cat = new Category()
                    {
                        Name = categoryName
                    };

                    context.Categories.Add(cat);
                    context.SaveChanges();

                    category = cat;
                }

                book.Categories.Add(category);
            }

            context.Books.Add(book);
            context.SaveChanges();

            var viewBook = context.Books
                .Where(b => b.Id == book.Id)
                .Select(b => new GetBookViewModel()
                {
                    Title = b.Title,
                    Description = b.Description,
                    Price = b.Price,
                    Copies = b.Copies,
                    AuthorId = b.AuthorId,
                    AuthorName = b.Author.FirstName,
                    Edition = b.Edition,
                    Categories = b.Categories.Select(c => c.Name)
                });
            
            return this.Ok(viewBook);
        }

        [Authorize]
        [HttpPut]
        [Route("buy/{id}")]
        public IHttpActionResult BuyBook(int id)
        {
            var book = context.Books.Find(id);

            if (book == null)
            {
                return this.BadRequest("Book doesn't exist.");
            }

            if (book.Copies < 1)
            {
                return this.BadRequest("Book is out of stock.");
            }

            string userId = this.User.Identity.GetUserId();
            var purshase = new Purshase()
            {
                Price = book.Price,
                DateOfPurshase = DateTime.Now,
                isRecalled = false,
                UserId = userId,
                BookId = book.Id
            };

            book.Copies--;
            context.Purshases.Add(purshase);
            context.SaveChanges();

            var viewPurshase = new PurshaseViewModel
            {
                Price = purshase.Price,
                DateOfPurshase = purshase.DateOfPurshase,
                isRecalled = purshase.isRecalled,
                User = this.User.Identity.GetUserName(),
                Book = purshase.Book.Title
            };

            return this.Ok(viewPurshase);
        }

        [Authorize]
        [HttpPut]
        [Route("recall/{id}")]
        public IHttpActionResult RecallBook(int id)
        {
            var book = context.Books.Find(id);

            if (book == null)
            {
                return this.BadRequest("Book doesn't exist.");
            }

            string userId = this.User.Identity.GetUserId();

            var purshase = context.Purshases
                .FirstOrDefault(p => p.UserId == userId && p.BookId == book.Id);
            
            if (purshase == null)
            {
                return this.BadRequest("You don't have this book.");
            }
            
            if (DateTime.Compare(DateTime.Now, purshase.DateOfPurshase.AddDays(30)) > 0)
            {
                return this.BadRequest("Date of purshase is more then 30 days.");
            }

            book.Copies++;
            purshase.isRecalled = true;
            context.SaveChanges();

            var viewPurshase = new PurshaseViewModel
            {
                Price = purshase.Price,
                DateOfPurshase = purshase.DateOfPurshase,
                isRecalled = purshase.isRecalled,
                User = this.User.Identity.GetUserName(),
                Book = purshase.Book.Title
            };

            return this.Ok(viewPurshase);
        }
    }
}