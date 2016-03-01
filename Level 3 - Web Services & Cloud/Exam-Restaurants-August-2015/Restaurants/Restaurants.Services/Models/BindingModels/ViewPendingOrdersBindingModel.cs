namespace Restaurants.Services.Models.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class ViewPendingOrdersBindingModel
    {
        [Required]
        public int StartPage { get; set; }

        [Required]
        public int Limit { get; set; }

        [Required]
        public int MealId { get; set; }
    }
}