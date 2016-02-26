namespace News.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class NewsModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        [MinLength(3)]
        public string Content { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }
    }
}
