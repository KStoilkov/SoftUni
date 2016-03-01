namespace Restaurants.Services.Controllers
{
    using Data;
    using Data.UnitOfWork;
    using Microsoft.AspNet.Identity;
    using Models.BindingModels;
    using Models.ViewModels;
    using Restaurants.Models;
    using System;
    using System.Linq;
    using System.Web.Http;

    [Authorize]
    [RoutePrefix("api")]
    public class OrdersController : BaseApiController
    {
        public OrdersController(IRestaurantsData data)
            : base(data)
        {
        }

        public OrdersController()
            : this(new RestaurantsData(new RestaurantsContext()))
        {
        }

        [HttpPost]
        [Route("Meals/{mealId}/Order")]
        public IHttpActionResult CreateNewOrder(int mealId, int? quantity)
        {
            var dbMeal = this.Data.Meals.All()
                .FirstOrDefault(m => m.Id == mealId);

            if (dbMeal == null)
            {
                return this.NotFound();
            }
            
            if (quantity == null)
            {
                return this.BadRequest("Quantity is missing.");
            }

            var loggedUserId = this.User.Identity.GetUserId();
            var order = new Order
            {
                MealId = dbMeal.Id,
                UserId = loggedUserId,
                Quantity = (int)quantity,
                OrderStatus = OrderStatus.Pending,
                CreatedOn = DateTime.Now
            };

            this.Data.Orders.Add(order);
            this.Data.SaveChanges();
            
            return this.Ok();
        }

        [HttpGet]
        public IHttpActionResult ViewPendingOrders([FromUri]ViewPendingOrdersBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (model == null)
            {
                return this.BadRequest("Model is missing.");
            }

            var dbMeal = this.Data.Meals.All()
                .FirstOrDefault(m => m.Id == model.MealId);
            if (dbMeal == null)
            {
                return this.NotFound();
            }

            var orders = this.Data.Orders.All()
                .Where(o => o.MealId == model.MealId)
                .OrderByDescending(o => o.CreatedOn)
                .Skip(model.StartPage * model.Limit)
                .Take(model.Limit)
                .Select(OrderViewModel.Create)
                .ToList();

            return this.Ok(orders);
        }
    }
}
