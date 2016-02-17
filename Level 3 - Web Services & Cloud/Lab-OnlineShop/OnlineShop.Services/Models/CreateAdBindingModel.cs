namespace OnlineShop.Services.Models
{
    using CustomValidationAttributes;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateAdBindingModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        
        [ValidateType]
        public int TypeId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ValidateAd]
        public IEnumerable<int> Categories { get; set; }
    }
}