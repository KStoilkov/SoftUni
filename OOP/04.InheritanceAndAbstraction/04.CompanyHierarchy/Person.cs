using System;

namespace _04.CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public string Id
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Id cannot be empty.");
                }
                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty.");
                }
                this.lastName = value;
            }
        }

        protected Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName + ", ID: " + this.Id);
        }
    }
}
