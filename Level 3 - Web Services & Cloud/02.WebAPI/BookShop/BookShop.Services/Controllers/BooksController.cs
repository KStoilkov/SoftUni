namespace BookShop.Services.Controllers
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Web.Http;
    using System.Web.Http.Description;
    using BookShop.Data;
    using BookShop.Models;

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
                return this.NotFound();
            }

            // TODO: Fix circular reference
            
            return this.Ok(book);
        }
    }
}