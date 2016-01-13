namespace StudentSystem.ConsoleClient
{
    using Data;
    using System.Linq;

    public class StudentSystemMain
    {
        public static void Main()
        {
            var context = new StudentSystemContext();
            var booksCount = context.Students.Count();
        }
    }
}
