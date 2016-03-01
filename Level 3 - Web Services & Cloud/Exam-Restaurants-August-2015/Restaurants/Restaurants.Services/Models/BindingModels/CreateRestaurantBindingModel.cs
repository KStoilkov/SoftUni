namespace Restaurants.Services.Models.BindingModels
{
    using System.ComponentModel.DataAnnotations;

    public class CreateRestaurantBindingModel
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        public int TownId { get; set; }
    }
}