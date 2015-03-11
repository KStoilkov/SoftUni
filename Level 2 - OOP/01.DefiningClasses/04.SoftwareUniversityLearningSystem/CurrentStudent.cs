namespace _04.SoftwareUniversityLearningSystem
{
    using System;

    class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age,
            long studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }
        
        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Current course cannot be null or empty.");
                }
                this.currentCourse = value;
            }
        }
    }
}
