namespace _04.SoftwareUniversityLearningSystem
{
    using System;

    class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age,
            long studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason 
        {
            get
            {
                return this.dropoutReason;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Dropout reason cannot be null or empty.");
                }
                this.dropoutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " " + this.Age + " years " + dropoutReason);
        }
    }
}
