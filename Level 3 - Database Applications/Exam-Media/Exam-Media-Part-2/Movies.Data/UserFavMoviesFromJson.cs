namespace Movies.Data
{
    using System.Collections.Generic;

    public class UserFavMoviesFromJson
    {
        private ICollection<string> favouriteMovies;

        public UserFavMoviesFromJson()
        {
            this.favouriteMovies = new HashSet<string>();
        }

        public string Username { get; set; }

        public ICollection<string> FavouriteMovies
        {
            get { return this.favouriteMovies; }
            set { this.favouriteMovies = value; }
        }
    }
}
