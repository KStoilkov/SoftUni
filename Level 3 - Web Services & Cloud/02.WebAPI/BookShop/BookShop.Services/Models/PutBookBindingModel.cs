namespace BookShop.Services.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class PutBookBindingModel
    {
        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int? Copies { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public DateTime Edition { get; set; }
    }
}