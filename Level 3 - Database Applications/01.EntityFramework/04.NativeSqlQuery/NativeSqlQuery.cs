namespace _04.NativeSqlQuery
{
    using System;
    using _01.DBContext;
    using System.Linq;
    using System.Diagnostics;

    public class NativeSqlQuery
    {
        public static SoftuniModel context = new SoftuniModel();

        public static void Main(string[] args)
        {
            var sw = new Stopwatch();

            sw.Start();
            PrintNamesWithNativeQuery();
            Console.WriteLine($"Native: {sw.Elapsed}");

            sw.Restart();
            PrintNamesWithLinqQuery();
            Console.WriteLine($"Linq: {sw.Elapsed}");
        }

        public static void PrintNamesWithLinqQuery()
        {
            var employees = context.Employees
                .Where(e => e.Projects.Any(p => p.StartDate.Year == 2002))
                .Select(e => e.FirstName);

            /* foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            } */
        }

        public static void PrintNamesWithNativeQuery()
        {
            string nativeSqlQuery =
                "SELECT e.FirstName FROM Employees e" +
                "JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID" +
                "JOIN Projects p ON ep.ProjectID = p.ProjectID" +
                "WHERE DATEPART(yyyy, p.StartDate) = 2002";

            var employees = context.Database.SqlQuery<string>(nativeSqlQuery);

            /* foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            } */
        }
    }
}
