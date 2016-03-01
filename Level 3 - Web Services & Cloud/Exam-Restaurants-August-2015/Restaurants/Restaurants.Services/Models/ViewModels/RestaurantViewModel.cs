namespace Restaurants.Services.Models.ViewModels
{
    using Restaurants.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public class RestaurantViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Town { get; set; }

        public string Owner { get; set; }
        
        public double? Rating { get; set; }

        public IEnumerable<string> Meals { get; set; }
        
        public static Expression<Func<Restaurant, RestaurantViewModel>> Create
        {
            get
            {
                return r => new RestaurantViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    Town = r.Town.Name,
                    Owner = r.Owner.UserName,
                    Meals = r.Meals.Select(m => m.Name),
                    Rating = r.Ratings.Select(ra => (int?)ra.Stars).Average() ?? 0.0
                };
            }
        }
    }
}