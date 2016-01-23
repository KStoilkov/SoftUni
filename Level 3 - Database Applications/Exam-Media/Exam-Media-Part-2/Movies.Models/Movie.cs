namespace Movies.Models
{
    using Movies.Models.enums;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public class Movie
    {
        private ICollection<User> usersThatMovieIsFavorite;
        private ICollection<Rating> ratings;

        public Movie()
        {
            this.usersThatMovieIsFavorite = new HashSet<User>();
            this.ratings = new HashSet<Rating>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Isbn { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Title { get; set; }

        public AgeRestriction? ageRestriction { get; set; }

        public virtual ICollection<User> UsersThatMovieIsFavorite
        {
            get { return this.usersThatMovieIsFavorite; }
            set { this.usersThatMovieIsFavorite = value; }
        }

        public virtual ICollection<Rating> Ratings
        {
            get { return this.ratings; }
            set { this.ratings = value; }
        }
    }
}
