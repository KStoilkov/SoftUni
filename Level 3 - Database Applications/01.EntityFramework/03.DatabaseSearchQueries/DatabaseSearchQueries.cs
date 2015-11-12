namespace _03.DatabaseSearchQueries
{
    using System;
    using System.Linq;
    using _01.DBContext;

    public class DatabaseSearchQueries
    {
        public static SoftuniModel context = new SoftuniModel();

        public static void Main(string[] args)
        {
            // Task 1
            FindEmployeesWithProjects(2001, 2003);

            // Task 2
            Find10Addresses();

            // Task 3
            SelectEmployeeById(147);

            // Task 4
            FindDepartmentsWithMoreEmployees();
        }

        private static void FindEmployeesWithProjects(int from, int to)
        {
            var employeesWithProjects = context.Employees
               .Where(e => e.Projects.Any(p => p.StartDate.Year >= from && p.StartDate.Year <= to))
               .Select(e => new
               {
                   FirstName = e.FirstName,
                   LastName = e.LastName,
                   ManagerName = e.Employee1.FirstName + " " + e.Employee1.LastName,
                   Projects = e.Projects
                       .Where(p => p.StartDate.Year >= from && p.StartDate.Year <= to)
                       .Select(p => new
                       {
                           Name = p.Name,
                           StartDate = p.StartDate,
                           EndDate = p.EndDate
                       }
                       )
               }
               );

             foreach (var employee in employeesWithProjects)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, Manager: {employee.ManagerName} \nProjects:");

                foreach (var project in employee.Projects)
                {
                    Console.WriteLine($"Name: {project.Name}, Start Date: {project.StartDate}, End Date: {project.EndDate}");
                }

                Console.WriteLine();
            } 
        }

        private static void Find10Addresses()
        {
            var addresses = context.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .Take(10)
                .Select(a => new
                {
                    AddressText = a.AddressText,
                    TownName = a.Town.Name,
                    EmployeeCount = a.Employees.Count
                });

            foreach (var address in addresses)
            {
                Console.WriteLine($"{address.AddressText}, {address.TownName} - {address.EmployeeCount} employees");
            }
        }

        private static void SelectEmployeeById(int id)
        {
            var employee = context.Employees
                .Where(e => e.EmployeeID == id)
                .Select(e => new
                {
                     FirstName = e.FirstName,
                     LastName = e.LastName,
                     JobTitle = e.JobTitle,
                     Projects = e.Projects
                        .OrderBy(p => p.Name)
                        .Select(p => p.Name)
                }).FirstOrDefault();

            Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} \nProjects:");

            foreach (var project in employee.Projects)
            {
                Console.WriteLine(project);
            }
        }

        private static void FindDepartmentsWithMoreEmployees()
        {
            var departments = context.Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .Select(d => new
                {
                    Name = d.Name,
                    Manager = d.Employees
                        .Where(e => e.EmployeeID == d.ManagerID)
                        .Select(e => e.FirstName),
                    Employees = d.Employees.Count
                });

            foreach (var department in departments)
            {
                Console.WriteLine($"--{department.Name} - Manager: {department.Manager}, Employees: {department.Employees}");
            }
        }
    }
}
