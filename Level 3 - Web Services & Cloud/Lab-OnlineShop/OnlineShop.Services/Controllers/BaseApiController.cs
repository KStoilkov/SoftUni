namespace OnlineShop.Services.Controllers
{
    using Data;
    using System.Web.Http;

    public class BaseApiController : ApiController
    {
        public BaseApiController() 
            : this (new OnlineShopContext())
        {

        }

        public BaseApiController(OnlineShopContext data)
        {
            this.Data = data;
        }

        protected OnlineShopContext Data { get; set; }
    }
}