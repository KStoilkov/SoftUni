namespace Restaurants.Services.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class AnonymousUserRestaurantViewModel
    {
        public string Name { get; set; }

        public IEnumerable<string> Meals { get; set; }

        public static Expression<Func<RestaurantViewModel, AnonymousUserRestaurantViewModel>> Create
        {
            get
            {
                return r => new AnonymousUserRestaurantViewModel
                {
                    Name = r.Name,
                    Meals = r.Meals
                };
            }
        }
    }
}