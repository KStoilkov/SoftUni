namespace _04.SoftwareUniversityLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SULSTest
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new OnsiteStudent("Pesho", "Geshov", 19, 159232, 5.5, "OOP", 4),
                new DropoutStudent("Toshko", "Toshkov", 21,123903, 2.2, "Familly reasons"),
                new GraduateStudent("Petko", "Petkov", 22, 652132, 5.6),
                new OnlineStudent("Todor", "Todorov", 25, 652982, 4.5, "Java Basics"),
                new OnsiteStudent("Geco", "Gecov", 35, 123002, 4.3, "OOP", 6),
                new OnsiteStudent("Mitio", "Mitkov", 18, 123123, 5.6, "JS Basics", 5),
                new OnlineStudent("Stefka", "Stefanova", 18, 545432, 5.8, "PHP Basics"),
                new OnsiteStudent("Galq", "Galenova", 20, 321321, 6, "OOP", 6)
            };

            var currentStudents = students
                .Where(s => s is CurrentStudent)
                .OrderBy(s => s.AverageGrade)
                .Select(s => new
                {
                    Name = s.FirstName + " " + s.LastName,
                    Age = s.Age,
                    AvgGrade = s.AverageGrade,
                    studentNumber = s.StudentNumber
                });

            foreach (var student in currentStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            var Gancho = new DropoutStudent("Gancho", "Gankov", 22, 123321, 2.2, "Too bad grade");
            Gancho.Reapply();

            Console.WriteLine();

            SeniorTrainer Petkan = new SeniorTrainer("Petkan", "Petkanov", 45);
            JuniorTrainer Goshko = new JuniorTrainer("Goshko", "Goshkov", 33);

            Goshko.CreateCourse("C# Intro");
            Petkan.CreateCourse("C# Basics");
            Petkan.DeleteCourse("C# Intro");
        }
    }
}
