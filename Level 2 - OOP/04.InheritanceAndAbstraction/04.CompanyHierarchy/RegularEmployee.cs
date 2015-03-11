namespace _04.CompanyHierarchy
{
    public abstract class RegularEmployee : Employee, IEmployee
    {
        protected RegularEmployee(string id, string firstName, string lastName, 
            int salary, Department department)
            : base (id, firstName, lastName, salary, department)
        {
            
        }
    }
}
