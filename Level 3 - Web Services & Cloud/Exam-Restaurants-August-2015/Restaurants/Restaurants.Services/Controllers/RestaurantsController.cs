namespace Restaurants.Services.Controllers
{
    using Data;
    using Data.UnitOfWork;
    using Microsoft.AspNet.Identity;
    using Models.BindingModels;
    using Models.ViewModels;
    using Restaurants.Models;
    using System.Linq;
    using System.Web.Http;

    [Authorize]
    [RoutePrefix("api/Restaurants")]
    public class RestaurantsController : BaseApiController
    {
        public RestaurantsController(IRestaurantsData data)
            : base(data)
        {
        }

        public RestaurantsController()
            : this(new RestaurantsData(new RestaurantsContext()))
        {
        }

        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetRestaurantsByTown([FromUri]int townId)
        {
            var town = this.Data.Towns.All().FirstOrDefault(t => t.Id == townId);

            if (town == null)
            {
                return this.NotFound();
            }

            var restaurants = this.Data.Restaurants.All()
                .Where(r => r.TownId == townId)
                .OrderByDescending(r => r.Ratings.Select(ra => (int?)ra.Stars).Average() ?? 0.0)
                .ThenBy(r => r.Name)
                .Select(RestaurantViewModel.Create);

            if (this.User.Identity.IsAuthenticated)
            {
                return this.Ok(restaurants);
            }
            else
            {
                var newRestaurants = restaurants
                    .Select(AnonymousUserRestaurantViewModel.Create);

                return this.Ok(newRestaurants);
            }
        }

        [HttpPost]
        public IHttpActionResult CreateRestaurant(CreateRestaurantBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (model == null)
            {
                return this.BadRequest("Model cannot be null.");
            }

            var town = this.Data.Towns.All()
                .FirstOrDefault(t => t.Id == model.TownId);

            if (town == null)
            {
                return this.NotFound();
            }

            var restaurant = new Restaurant
            {
                Name = model.Name,
                TownId = model.TownId,
                OwnerId = this.User.Identity.GetUserId()
            };

            this.Data.Restaurants.Add(restaurant);
            this.Data.SaveChanges();

            var restaurantViewModel = this.Data.Restaurants.All()
                .Where(r => r.Id == restaurant.Id)
                .Select(RestaurantViewModel.Create)
                .FirstOrDefault();

            return this.Created($"api/Restaurants/{restaurant.Id}", restaurantViewModel);
        }

        [HttpPost]
        [Route("{id}/rate")]
        public IHttpActionResult RateRestaurant(int id, [FromUri]int stars)
        {
            var restaurant = this.Data.Restaurants.All()
                .Where(r => r.Id == id)
                .Select(r => new
                {
                    Id = r.Id,
                    OwnerId = r.OwnerId,
                    AlreadyRatedUsersIds = r.Ratings.Select(ra => ra.UserId)
                })
                .FirstOrDefault();

            if (restaurant == null)
            {
                return this.NotFound();
            }
            
            string loggedUserId = this.User.Identity.GetUserId();
            var dbUser = this.Data.Users.All()
                .FirstOrDefault(u => u.Id == loggedUserId);

            if (dbUser == null)
            {
                return this.BadRequest("Invalid Token");
            }

            if (loggedUserId == restaurant.OwnerId)
            {
                return this.BadRequest("You cannot rate your own restaurant.");
            }

            if (restaurant.AlreadyRatedUsersIds.Contains(loggedUserId))
            {
                return this.BadRequest("You already rated this restaurant.");
            }
            
            if (stars < 1 || stars > 10)
            {
                return this.BadRequest("Rate must be from 1 to 10.");
            }

            var rate = new Rating
            {
                Stars = stars,
                RestaurantId = restaurant.Id,
                UserId = loggedUserId
            };

            this.Data.Ratings.Add(rate);
            this.Data.SaveChanges();

            return this.Ok();
        }

        [HttpGet]
        [Route("{id}/Meals")]
        public IHttpActionResult GetRestaurantMeals([FromUri]int id)
        {
            var restaurant = this.Data.Restaurants.All()
                .Where(r => r.Id == id)
                .Select(r => new
                {
                    Id = r.Id,
                    Meals = r.Meals
                })
                .FirstOrDefault();

            if (restaurant == null)
            {
                return this.NotFound();
            }

            var restaurantMeals = restaurant.Meals
                .AsQueryable()
                .Select(MealViewModel.Create)
                .ToList();

            return this.Ok(restaurantMeals);
        }
    }
}
