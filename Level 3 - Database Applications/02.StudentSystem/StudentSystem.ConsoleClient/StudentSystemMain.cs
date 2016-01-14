namespace StudentSystem.ConsoleClient
{
    using Data;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentSystemMain
    {
        public static void Main()
        {
            var context = new StudentSystemContext();

            //Problem 3 Solutions
            //task1(context);
            //task2(context);
            //task3(context);
            //task4(context);
            task5(context);
        }

        private static void task1(StudentSystemContext context)
        {
            var students = context.Students.Select(s => new
            {
                Name = s.Name,
                Homeworks = s.Homeworks.Select(h => new
                {
                    Content = h.Content,
                    ContentType = h.ContentType
                })
            });

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);

                var studentHomeworks = student.Homeworks.ToList();
                foreach (var homework in studentHomeworks)
                {
                    Console.WriteLine(homework.Content + "/" + homework.ContentType);
                }
                Console.WriteLine();
            }
        }

        private static void task2(StudentSystemContext context)
        {
            var courses = context.Courses.Select(c => new
            {
                Name = c.Name,
                Description = c.Description,
                Resources = c.Resources.Select(r => new
                {
                    Name = r.Name,
                    Type = r.TypeOfResource,
                    URL = r.URL
                })
            });

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
                Console.WriteLine(course.Description);

                var courseResources = course.Resources.ToList();
                foreach (var resource in courseResources)
                {
                    Console.WriteLine(resource.Name + " / " + resource.Type + " / " + resource.URL);
                }
                Console.WriteLine();
            }
        }

        private static void task3(StudentSystemContext context)
        {
            var courses = context.Courses
                .Where(c => c.Resources.Count > 3)
                .OrderBy(c => c.Resources.Count)
                .ThenBy(c => c.StartDate)
                .ThenByDescending(c => c.EndDate)
                .Select(c => new
                {
                    Name = c.Name,
                    Resorces = c.Resources.Count
                });


            foreach (var course in courses)
            {
                Console.WriteLine(course.Name + " Resources: " + course.Resorces);
            }
        }

        private static void task4(StudentSystemContext context)
        {
            var date = new DateTime(2015, 04, 05);

            var courses = context.Courses
                .Where(c => DateTime.Compare(c.StartDate, date) <= 0 && DateTime.Compare(c.EndDate, date) >= 0)
                .OrderByDescending(c => c.Students.Count)
                .ThenByDescending(c => DbFunctions.DiffDays(c.StartDate, c.EndDate))
                .Select(c => new
                {
                    Name = c.Name,
                    StartDate = c.StartDate,
                    EndDate = c.EndDate,
                    CourseDuration = DbFunctions.DiffDays(c.StartDate, c.EndDate),
                    StudentsEnrolled = c.Students.Count
                });

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name + " " + 
                    course.StartDate + " - " +
                    course.EndDate + " : " + 
                    course.CourseDuration + " Days");
                Console.WriteLine("Students: " + course.StudentsEnrolled);
                Console.WriteLine();
            }
        }
        
        private static void task5(StudentSystemContext context)
        {
            var students = context.Students
                .OrderByDescending(s => s.Courses.Sum(c => c.Price))
                .ThenByDescending(s => s.Courses.Count)
                .ThenBy(s => s.Name)
                .Select(s => new
                {
                    Name = s.Name,
                    Courses = s.Courses.Count,
                    TotalPrice = s.Courses.Sum(c => c.Price),
                    AveragePrice = s.Courses.Average(c => c.Price)
                });

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, Courses count: {student.Courses}");
                Console.WriteLine($"Total Price: {student.TotalPrice:0.00}BGN , Average Price: {student.AveragePrice:0.00}BGN ");
                Console.WriteLine();
            }
        }
    }
}
