namespace Restaurants.Services.Models.ViewModels
{
    using Restaurants.Models;
    using System;
    using System.Linq.Expressions;

    public class OrderViewModel
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public DateTime DateOfCreation { get; set; }

        public string Meal { get; set; }

        public static Expression<Func<Order, OrderViewModel>> Create
        {
            get
            {
                return o => new OrderViewModel
                {
                    Id = o.Id,
                    Status = o.OrderStatus.ToString(),
                    DateOfCreation = o.CreatedOn,
                    Meal = o.Meal.Name
                };
            }
        }
    }
}