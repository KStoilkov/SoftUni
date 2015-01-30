namespace _04.CompanyHierarchy
{
    using System;

    public abstract class Employee : Person, IEmployee
    {
        private int salary;

        public int Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be less than 0.");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }

        protected Employee(string id, string firstName, string lastName, 
            int salary, Department department) : base (id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public override string ToString()
        {
            return base.ToString() + ", Salary: " + this.Salary;
        }
    }
}