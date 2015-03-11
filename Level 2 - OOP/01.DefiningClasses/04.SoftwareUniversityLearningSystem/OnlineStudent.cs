namespace _04.SoftwareUniversityLearningSystem
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age,
            long studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
        }
    }
}
