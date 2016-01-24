namespace Movies.ConsoleClient
{
    using Data;
    using Models.enums;
    using System.IO;
    using System.Linq;
    using System.Web.Script.Serialization;
    using System;

    public class MoviesMain
    {
        static void Main()
        {
            var context = new MoviesContext();

            var serializer = new JavaScriptSerializer();

            // Query 1
            AdultMovies(context, serializer);

            // Query 2
            RatedMoviesByUser(context, serializer);

            // Query 3
            Top10FavoriteMovies(context, serializer);
        }

        private static void Top10FavoriteMovies(MoviesContext context, JavaScriptSerializer serializer)
        {
            var movies = context.Movies
                .Where(m => m.AgeRestriction == AgeRestriction.Teen)
                .OrderByDescending(m => m.UsersThatMovieIsFavorite.Count)
                .ThenBy(m => m.Title)
                .Take(10)
                .Select(m => new
                {
                    isbn = m.Isbn,
                    title = m.Title,
                    favouriteBy = m.UsersThatMovieIsFavorite.Select(u => u.Username)
                });

            string json = serializer.Serialize(movies);

            File.WriteAllText("../../../top-10-favourite-movies.json", json);
        }

        private static void RatedMoviesByUser(MoviesContext context, JavaScriptSerializer serializer)
        {
            var user = context.Users
                .Where(u => u.Username == "jmeyery")
                .Select(u => new
                {
                    username = u.Username,
                    ratedMovies = u.Ratings
                    .OrderBy(r => r.Movie.Title)
                    .Select(r => new
                    {
                        title = r.Movie.Title,
                        userRating = r.Stars,
                        averageRating = r.Movie.Ratings.Average(ra => ra.Stars)
                    })
                });

            string json = serializer.Serialize(user);

            File.WriteAllText("../../../rated-movies-by-jmeyery.json", json);
        }

        private static void AdultMovies(MoviesContext context, JavaScriptSerializer serializer)
        {
            var movies = context.Movies
                .Where(m => m.AgeRestriction == AgeRestriction.Adult)
                .OrderBy(m => m.Title)
                .ThenByDescending(m => m.Ratings.Count)
                .Select(m => new
                {
                    title = m.Title,
                    ratingsGiven= m.Ratings.Count
                });

            string json = serializer.Serialize(movies);

            File.WriteAllText("../../../adult-movies.json", json);
        }

        
    }
}
