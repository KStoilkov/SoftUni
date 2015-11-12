namespace _05.ConcurrentDatabaseChanges
{
    using _01.DBContext;

    public class ConcurrentDatabaseChanges
    {
        public static void Main(string[] args)
        {
            var firstContext = new SoftuniModel();
            var secondContext = new SoftuniModel();

            var firstEmployee = firstContext.Employees.Find(1);
            var secondEmployee = secondContext.Employees.Find(2);

            firstEmployee.FirstName = "Stamat";
            secondEmployee.FirstName = "Kircho";

            firstContext.SaveChanges();
            secondContext.SaveChanges();
        }
    }
}
