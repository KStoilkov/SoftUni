﻿namespace StudentSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class License
    {
        public License()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ResourceId { get; set; }

        public virtual Resource Resource { get; set; }
    }
}
