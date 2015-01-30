namespace _01.School
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Discipline : IName, IDetails
    {
        private string name;
        private int numberOfLectures;
        private List<Student> students;
        private string details;

        public string Name
        {
            get { return this.name; }
            set 
            { 
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be less than 0.");
                }
                this.numberOfLectures = value;
            }
        }

        public List<Student> Students { get; set; }

        public string Details { get; set; }

        public Discipline(string name, int numberOfLectures, List<Student> students, string details)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
            this.Details = details;
        }

        public Discipline(string name, int numberOfLectures, List<Student> students) 
            : this (name, numberOfLectures, students, null)
        {
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" Name: " + this.Name + ", Number of lectures: " + this.NumberOfLectures);

            foreach (var student in this.Students)
            {
                sb.Append("   " + student);
            }

            if (this.Details != null)
            {
                sb.Append("Details: " + this.Details);
            }

            return sb.ToString();
        }
    }
}
