﻿namespace _04.CompanyHierarchy
{
    using System.Collections.Generic;

    public interface IManager
    {
         List<Employee> Employees { get; set; }
    }
}
