namespace _02.ConcurrentUpdates
{
    using _01.NewsDatabase;
    using System;

    public class ConcurrentUpdatesMain
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var context = new NewsContext();
                var news = context.News.Find(1);

                Console.WriteLine("Current News content: " + news.Content);
                Console.Write("Enter new content: ");
                try
                {
                    string newContent = Console.ReadLine();
                    news.Content = newContent;
                    context.SaveChanges();
                    Console.WriteLine("Content succsessfully changed.");
                    Console.WriteLine("New content: " + news.Content);
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to change content. Try again later.");
                }
            }
        }
    }
}
