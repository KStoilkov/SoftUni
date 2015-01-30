namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    class Developer : RegularEmployee, IDeveloper
    {
        public List<Project> Projects { get; set; }

        public Developer(string id, string firstName, string lastName, 
            int salary, Department department, List<Project> projects)
            : base (id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString() + " ");

            foreach (var project in this.Projects)
            {
                result.Append(" || ");
                result.Append(project);
            }

            return result.ToString();
        }
    }
}
