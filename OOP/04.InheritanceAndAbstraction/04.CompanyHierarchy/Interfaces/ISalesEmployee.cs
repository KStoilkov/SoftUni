namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;

    public interface ISalesEmployee
    {
        List<Sale> Sales { get; set; }
    }
}
