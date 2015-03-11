namespace _04.CompanyHierarchy.Interfaces
{
    using System;

    public interface IProject
    {
        string ProjectName { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        State State { get; set; }

        void CloseProject();
    }
}