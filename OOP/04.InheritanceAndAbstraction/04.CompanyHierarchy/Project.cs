namespace _04.CompanyHierarchy
{
    using System;
    using Interfaces;

    public class Project : IProject
    {
        private string projectName;
        private string details;

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Project Name cannot be empty.");
                }
                this.projectName = value;
            }
        }

        public DateTime StartDate { get; set; }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Project details cannot be empty.");
                }
                this.details = value;
            }
        }

        public State State { get; set; }

        public Project(string projectName, DateTime startDate, string details, State state)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public void CloseProject()
        {
            this.State = State.Closed;
        }

        public override string ToString()
        {
            return string.Format("Project Name: {0}, Start date: {1}, Details: {2}, State: {3}",
                this.ProjectName, this.StartDate.ToString("dd-MM-yyyy"), this.Details, this.State);
        }
    }
}
