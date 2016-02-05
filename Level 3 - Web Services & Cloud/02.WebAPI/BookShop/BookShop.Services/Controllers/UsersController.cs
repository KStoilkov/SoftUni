namespace BookShop.Services.Controllers
{
    using Data;
    using Models;
    using System.Linq;
    using System.Web.Http;

    [RoutePrefix("api/user")]
    public class UsersController : ApiController
    {
        private BookShopContext context;

        public UsersController()
        {
            this.context = new BookShopContext();
        }

        [Authorize]
        [HttpGet]
        [Route("{username}/purshases")]
        public IHttpActionResult GetUserPurshases(string username)
        {
            var user = context.Users
                .FirstOrDefault(u => u.UserName == username);

            if (user == null)
            {
                return this.BadRequest("User doesn't exist.");
            }

            var purshases = user.Purshases
                .Select(p => new PurshaseViewModel
                {
                    Price = p.Price,
                    DateOfPurshase = p.DateOfPurshase,
                    isRecalled = p.isRecalled,
                    User = p.User.UserName,
                    Book = p.Book.Title
                });

            return this.Ok(purshases);
        }
    }
}
