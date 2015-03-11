namespace _04.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            List<Sale> sales = new List<Sale>
            {
                new Sale("Animals", new DateTime(2014, 9, 2), 649.99),
                new Sale("Yolo game", new DateTime(2015, 11, 5), 780)
            };

            List<Project> projects = new List<Project>
            {
                new Project("Yolo game", new DateTime(2015, 10, 5), "No Details", State.Open),
                new Project("Business report program", new DateTime(2014, 8, 4), "No Details", State.Closed)
            };

            List<Project> moreProjects = new List<Project>
            {
                new Project("Animals", new DateTime(2014, 8, 1), "Amazing Project", State.Closed),
                new Project("Hola", new DateTime(2015, 5, 2), "No Details", State.Open)
            };

            Developer kiro = new Developer(
                "547823", "Kiro", "Kirov", 1100, Department.Production, projects);
            Developer svetla = new Developer(
                "999231", "Svetla", "Svetlenova", 1500, Department.Production, moreProjects);
            SalesEmployee petkan = new SalesEmployee(
                "123321", "Petko", "Petkov", 1450, Department.Sales, sales);

            List<Employee> employeesUnderControl = new List<Employee> { kiro, svetla, petkan };

            Manager Toshe = new Manager("875123", "Toshko", "Toshov", 1400,
               Department.Production, employeesUnderControl);

            List<Employee> allEmployees = new List<Employee> { kiro, svetla, petkan, Toshe };

            foreach (var employee in allEmployees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }
            
        }
    }
}
