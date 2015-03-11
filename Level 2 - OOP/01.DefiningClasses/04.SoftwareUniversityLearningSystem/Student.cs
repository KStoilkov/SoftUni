namespace _04.SoftwareUniversityLearningSystem
{
    using System;
    public class Student : Person
    {
        private long studentNumber;
        private double averageGrade;

        public Student(string firstName, string lastName, int age, 
            long studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public long StudentNumber 
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Student number cannot be less than 0.");
                }
                this.studentNumber = value;
            }
        }

        public double AverageGrade 
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Not a valid grade.");   
                }
                this.averageGrade = value;
            }
        }
    }
}
