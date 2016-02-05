namespace BookShop.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Purshase
    {
        public Purshase()
        {

        }

        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime DateOfPurshase { get; set; }

        [Required]
        public bool isRecalled { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
