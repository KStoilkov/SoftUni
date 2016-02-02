namespace Movies.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Rating
    {
        public Rating()
        {

        }

        [Key]
        public int Id { get; set; }

        public int Stars { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
