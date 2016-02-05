namespace BookShop.Services.Controllers
{
    using BookShop.Models;
    using Data;
    using Models;
    using System.Linq;
    using System.Web.Http;
    using System.Web.OData;

    [RoutePrefix("api/authors")]
    public class AuthorsController : ApiController
    {
        private BookShopContext context;

        public AuthorsController()
        {
            this.context = new BookShopContext();
        }

        [HttpGet]
        [EnableQuery]
        public IHttpActionResult GetAuthors()
        {
            var authors = context.Authors
                .Select(a => new GetAuthorViewModel()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Books = a.Books.Select(b => b.Title)
                });

            return this.Ok(authors);
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
                return this.BadRequest("Author doesn't exist.");
            }

            var viewAuthor = new GetAuthorViewModel()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Books = author.Books.Select(b => b.Title)
            };

            return this.Ok(viewAuthor);
        }

        [HttpGet]
        [EnableQuery]
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
