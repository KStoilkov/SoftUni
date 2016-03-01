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
    [RoutePrefix("api/Meals")]
    public class MealsController : BaseApiController
    {
        public MealsController(IRestaurantsData data)
            : base(data)
        {
        }

        public MealsController()
            : this(new RestaurantsData(new RestaurantsContext()))
        {
        }

        [HttpPost]
        public IHttpActionResult CreateNewMeal(CreateMealBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (model == null)
            {
                return this.BadRequest("Model cannot be null.");
            }

            var dbRestaurant = this.Data.Restaurants.All()
                .Where(r => r.Id == model.RestaurantId)
                .Select(r => new
                {
                    Id = r.Id,
                    OwnerId = r.OwnerId
                })
                .FirstOrDefault();

            if (dbRestaurant == null)
            {
                return this.BadRequest($"Restaurant with Id: {dbRestaurant.Id} doesn't exist.");
            }

            var loggedUserId = this.User.Identity.GetUserId();
            if (dbRestaurant.OwnerId != loggedUserId)
            {
                return this.BadRequest("You are not the owner of the restaurant.");
            }

            var dbType = this.Data.MealTypes.All().FirstOrDefault(mt => mt.Id == model.TypeId);
            if (dbType == null)
            {
                return this.BadRequest($"Meal Type with Id: {dbType.Id} doesn't exist.");
            }

            var meal = new Meal
            {
                Name = model.Name,
                Price = model.Price,
                TypeId = model.TypeId,
                RestaurantId = model.RestaurantId
            };

            this.Data.Meals.Add(meal);
            this.Data.SaveChanges();

            var dbMeal = this.Data.Meals.All()
                .Where(m => m.Id == meal.Id)
                .Select(MealViewModel.Create)
                .FirstOrDefault();

            return this.Created($"api/Meals/{meal.Id}", dbMeal);
        }

        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult EditMeal(int id, EditMealBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            if (model == null)
            {
                return this.BadRequest("Model cannot be null.");
            }

            var dbMeal = this.Data.Meals.All()
                .FirstOrDefault(m => m.Id == id);

            if (dbMeal == null)
            {
                return this.NotFound();
            }

            var loggedUserId = this.User.Identity.GetUserId();
            if (dbMeal.Restaurant.OwnerId != loggedUserId)
            {
                return this.BadRequest("You are not the owner of the restaurant.");
            }

            var dbType = this.Data.MealTypes.All().FirstOrDefault(mt => mt.Id == model.TypeId);
            if (dbType == null)
            {
                return this.BadRequest($"Meal Type with Id: {dbType.Id} doesn't exist.");
            }

            dbMeal.Name = model.Name;
            dbMeal.Price = model.Price;
            dbMeal.TypeId = model.TypeId;
            this.Data.SaveChanges();

            var editedMeal = this.Data.Meals.All()
                .Where(m => m.Id == id)
                .Select(MealViewModel.Create)
                .FirstOrDefault();

            return this.Ok(editedMeal);
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult DeleteMeal(int id)
        {
            var dbMeal = this.Data.Meals.All()
                .FirstOrDefault(m => m.Id == id);

            if (dbMeal == null)
            {
                return this.NotFound();
            }

            var loggedUserId = this.User.Identity.GetUserId();
            if (dbMeal.Restaurant.OwnerId != loggedUserId)
            {
                return this.BadRequest("You are not the owner of the restaurant.");
            }

            this.Data.Meals.Delete(dbMeal);
            this.Data.SaveChanges();

            return this.Ok(new
            {
                Message = $"Meal #{dbMeal.Id} deleted."
            });
        }
    }
}
