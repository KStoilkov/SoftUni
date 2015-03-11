namespace _02.Human__Student_and_Worker
{
    using System;

    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Fault number must be [5-10] digits long");
                }
                this.facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            return string.Format(this.FirstName + " " + this.LastName + " | " + this.FacultyNumber);
        }
    }
}
