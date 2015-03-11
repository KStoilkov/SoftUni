namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;
    using System.Text;

    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales; 

        public List<Sale> Sales { get; set; }

        public SalesEmployee(string id, string firstName, string lastName,
            int salary, Department department, List<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString() + " ");

            foreach (var sale in this.Sales)
            {
                result.Append(" || ");
                result.Append(sale);
            }
            

            return result.ToString();
        }
    }
}
