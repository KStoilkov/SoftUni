namespace _06.CallAStoredProcedure
{
    using System;
    using _01.DBContext;

    public class CallAStoredProcedure
    {
        public static void Main(string[] args)
        {
            var context = new SoftuniModel();
            var projects = context.GetEmployeeProjects("Ruth", "Ellerbrock");

            foreach (var project in projects)
            {
                Console.WriteLine(project);
            }
        }
    }
}
