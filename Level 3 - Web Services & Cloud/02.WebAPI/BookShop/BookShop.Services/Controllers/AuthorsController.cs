namespace BookShop.Services.Controllers
{
    using BookShop.Models;
    using Data;
    using Models;
    using System.Linq;
    using System.Web.Http;

    [RoutePrefix("api/authors")]
    public class AuthorsController : ApiController
    {
        private BookShopContext context;

        public AuthorsController()
        {
            this.context = new BookShopContext();
        }

        [HttpGet]
        public IHttpActionResult GetAuthors()
        {
            var books = context.Authors.ToList();

            return this.Ok(books);
        }

        [HttpPost]
        public IHttpActionResult PostAuthor([FromUri]PostAuthorBindingModel authorModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            Author author = new Author
            {
                FirstName = authorModel.FirstName,
                LastName = authorModel.LastName
            };

            this.context.Authors.Add(author);
            this.context.SaveChanges();

            return this.Ok(author);
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetAuthor(int id)
        {
            var author = context.Authors.Find(id);

            if (author == null)
            {
                return this.BadRequest("Invalid Author Id");
            }

            return this.Ok(author);
        }

        [HttpGet]
        [Route("{id}/books")]
        public IHttpActionResult GetAuthorBooks(int id)
        {
            var author = context.Authors.Find(id);

            if (author == null)
            {
                return this.BadRequest("Author doesn't exist.");
            }

            var authorBooks = author.Books
                .Select(b => new AuthorBooksViewModel
                {
                    Title = b.Title,
                    Description = b.Description,
                    Price = b.Price,
                    Copies = b.Copies,
                    Edition = b.Edition,
                    Categories = b.Categories.Select(c => c.Name)
                });
            
            return this.Ok(authorBooks);
        }
    }
}
