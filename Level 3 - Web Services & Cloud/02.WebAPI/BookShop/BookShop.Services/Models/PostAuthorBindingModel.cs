﻿namespace BookShop.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PostAuthorBindingModel
    {
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
    }
}