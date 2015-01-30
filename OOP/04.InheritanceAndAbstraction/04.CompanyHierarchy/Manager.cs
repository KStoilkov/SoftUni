namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee, IManager
    {
        public List<Employee> Employees { get; set; }

        public Manager(string id, string firstName, string lastName, int salary, 
            Department department, List<Employee> employees) 
            : base (id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString() + " ");

            foreach (var employee in this.Employees)
            {
                result.Append(" || ");
                result.Append(employee);
            }

            return result.ToString();
        }
    }
}
