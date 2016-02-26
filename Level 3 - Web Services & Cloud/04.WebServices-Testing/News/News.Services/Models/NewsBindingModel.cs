namespace News.Services.Models
{
    using System.ComponentModel.DataAnnotations;

    public class NewsBindingModel
    {
        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        [MinLength(3)]
        public string Content { get; set; }
    }
}