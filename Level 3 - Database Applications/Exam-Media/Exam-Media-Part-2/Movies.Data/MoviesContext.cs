namespace Movies.Data
{
    using Migrations;
    using Models;
    using System.Data.Entity;

    public class MoviesContext : DbContext
    {
        public MoviesContext()
            : base("name=MoviesContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesContext, Configuration>());
        }

        public IDbSet<Country> Countries { get; set; }
        public IDbSet<Movie> Movies { get; set; }
        public IDbSet<Rating> Ratings { get; set; }
        public IDbSet<User> Users { get; set; }
    }
}