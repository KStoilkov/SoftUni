namespace _04.SoftwareUniversityLearningSystem
{
    using System;

    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }
        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("The course " + courseName + " has been deleted.");
        }
    }
}
