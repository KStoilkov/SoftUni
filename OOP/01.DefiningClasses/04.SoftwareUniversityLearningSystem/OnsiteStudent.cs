namespace _04.SoftwareUniversityLearningSystem
{
    using System;

    class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age,
            long studentNumber, double averageGrade, string currentCourse,
            int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get 
            { 
                return this.numberOfVisits; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of visits cannot be less than 0.");
                }
                this.numberOfVisits = value; 
            }
        }
        
    }
}
