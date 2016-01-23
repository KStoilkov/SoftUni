namespace Movies.ConsoleClient
{
    using Data;
    using System.Linq;
    public class MoviesMain
    {
        static void Main()
        {
            var context = new MoviesContext();
            var usersCount = context.Users.Count();
        }
    }
}
