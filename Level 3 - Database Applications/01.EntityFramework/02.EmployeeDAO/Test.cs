namespace _02.EmployeeDAO
{
    using System;
    using _01.DBContext;

    public class Test
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "Gosho",
                LastName = "Goshov",
                JobTitle = "Research and Development Engineer",
                DepartmentID = 2,
                HireDate = DateTime.Now,
                Salary = 45000
            };

            DAO.Add(employee);

            Console.WriteLine(employee.EmployeeID);

            DAO.Modify(employee,
                "Petko",
                "Petrov", 
                "Petrov",
                "Research and Development Engineer",
                2,
                null,
                DateTime.Now,
                50000,
                null);

            var emp = DAO.FindByKey(employee.EmployeeID);

            Console.WriteLine(emp.FirstName + ' ' + emp.LastName);

            DAO.Delete(employee);

        }
    }
}
