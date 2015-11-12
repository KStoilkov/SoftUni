namespace _02.EmployeeDAO
{
    using System;
    using _01.DBContext;

    public static class DAO
    {
        private static SoftuniModel context = new SoftuniModel();

        public static void Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public static Employee FindByKey(object key)
        {
            var employee = context.Employees.Find(key);

            return employee;
        }

        public static void Modify(Employee employee, 
            string firstName, 
            string middleName,
            string lastName,
            string jobTitle,
            int departmentId,
            int? managerId,
            DateTime hireDate,
            decimal salary,
            int? addressId)
        {
            employee.FirstName = firstName;
            employee.MiddleName = middleName;
            employee.LastName = lastName;
            employee.JobTitle = jobTitle;
            employee.DepartmentID = departmentId;
            employee.ManagerID = managerId;
            employee.HireDate = hireDate;
            employee.Salary = salary;
            employee.AddressID = addressId;

            context.SaveChanges();
        }

        public static void Delete(Employee employee)
        {
            context.Employees.Remove(employee);

            context.SaveChanges();
        }
    }
}
