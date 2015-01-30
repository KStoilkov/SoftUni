namespace _01.School
{
    using System;

    public abstract class Person : IName, IDetails
    {
        private string name;
        private string details;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        protected Person(string name, string details)
        {
            this.Name = name;
            this.Details = details;
        }

        protected Person(string name) : this (name, null)
        {
        }
    }
}
