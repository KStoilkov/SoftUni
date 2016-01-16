using System.Linq;

namespace _01.NewsDatabase
{
    public class NewsDatabaseMain
    {
        static void Main(string[] args)
        {
            var context = new NewsContext();
            var newsCount = context.News.Count();
        }
    }
}
