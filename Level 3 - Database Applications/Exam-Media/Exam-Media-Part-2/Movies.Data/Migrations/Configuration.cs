namespace Movies.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Web.Script.Serialization;
    using System;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Movies.Data.MoviesContext";
        }

        protected override void Seed(MoviesContext context)
        {
            var serializer = new JavaScriptSerializer();

            if (!context.Countries.Any())
            {
                seedCountries(context, serializer);
            }

            if (!context.Movies.Any())
            {
                seedMovies(context, serializer);
            }

            if (!context.Users.Any())
            {
                seedUsers(context, serializer);
                seedUsersFavoriteMovies(context, serializer);
            }

            if (!context.Ratings.Any())
            {
                seedRatings(context, serializer);
            }
        }

        private void seedMovies(MoviesContext context, JavaScriptSerializer serializer)
        {
            using (StreamReader reader = new StreamReader("../../../movies.json"))
            {
                var json = reader.ReadToEnd();
                
                Movie[] movies = serializer.Deserialize<Movie[]>(json);

                foreach (var movie in movies)
                {
                    context.Movies.Add(movie);
                }

                context.SaveChanges();
            }
        }

        private void seedCountries(MoviesContext context, JavaScriptSerializer serializer)
        {
            using (StreamReader reader = new StreamReader("../../../countries.json"))
            {
                var json = reader.ReadToEnd();
                
                Country[] countries = serializer.Deserialize<Country[]>(json);

                foreach (var c in countries)
                {
                    context.Countries.Add(c);
                }

                context.SaveChanges();
            }
        }

        private void seedUsers(MoviesContext context, JavaScriptSerializer serializer)
        {
            using (StreamReader reader = new StreamReader("../../../users.json"))
            {
                var json = reader.ReadToEnd();
                
                UserFromJson[] users = serializer.Deserialize<UserFromJson[]>(json);

                var dbCountries = context.Countries.ToList();

                foreach (var user in users)
                {
                    int? countryId = null;
                    var country = dbCountries.FirstOrDefault(c => c.Name == user.Country);

                    if (country != null)
                    {
                        countryId = country.Id;
                    }

                    User u = new User
                    {
                        Username = user.Username,
                        Email = user.Email,
                        Age = user.Age,
                        CountryId = countryId
                    };
                     
                    context.Users.Add(u);
                }

                context.SaveChanges();
            }
        }

        private void seedUsersFavoriteMovies(MoviesContext context, JavaScriptSerializer serializer)
        {
            using (StreamReader reader = new StreamReader("../../../users-and-favourite-movies.json"))
            {
                var json = reader.ReadToEnd();

                var users = context.Users.ToList();
                var movies = context.Movies.ToList();

                UserFavMoviesFromJson[] usersFromJson = serializer.Deserialize<UserFavMoviesFromJson[]>(json);

                foreach (var userJson in usersFromJson)
                {
                    var user = users.FirstOrDefault(u => u.Username == userJson.Username);

                    foreach (var isbn in userJson.FavouriteMovies)
                    {
                        Console.WriteLine(isbn);
                        Movie movie = movies.FirstOrDefault(m => m.Isbn == isbn);
                        user.FavoriteMovies.Add(movie);
                    }    
                }

                context.SaveChanges();
            }
        }

        private void seedRatings(MoviesContext context, JavaScriptSerializer serializer)
        {
            using (StreamReader reader = new StreamReader("../../../movie-ratings.json"))
            {
                var json = reader.ReadToEnd();
                var users = context.Users.ToList();
                var movies = context.Movies.ToList();

                var ratingsFromJson = serializer.Deserialize<RatingFromJson[]>(json);

                foreach (var rating in ratingsFromJson)
                {
                    var userId = users.FirstOrDefault(u => u.Username == rating.user).Id;
                    var movieId = movies.FirstOrDefault(m => m.Isbn == rating.movie).Id;

                    Rating r = new Rating
                    {
                        UserId = userId,
                        MovieId = movieId,
                        Stars = rating.rating
                    };

                    context.Ratings.Add(r);
                }

                context.SaveChanges();
            }
        }
    }
}
