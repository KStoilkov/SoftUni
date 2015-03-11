using System.Collections.Generic;

namespace _04.CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
        List<Project> Projects { get; set; }
    }
}