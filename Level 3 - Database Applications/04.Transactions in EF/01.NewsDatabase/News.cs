namespace _01.NewsDatabase
{
    using System.ComponentModel.DataAnnotations;

    public class News
    {
        public News()
        {

        }

        [Key]
        public int Id { get; set; }

        [ConcurrencyCheck]
        public string Content { get; set; }

    }
}
