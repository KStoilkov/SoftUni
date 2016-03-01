namespace Restaurants.Services.Controllers
{
    using Data.UnitOfWork;
    using System.Web.Http;

    public class BaseApiController : ApiController
    {
        public IRestaurantsData Data { get; set; }

        public BaseApiController(IRestaurantsData data)
        {
            this.Data = data;
        }
    }
}
