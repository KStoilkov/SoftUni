namespace StudentSystem.Data.Migrations
{
    using Models;
    using Models.enums;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
            this.ContextKey = "StudentSystem.Data.StudentSystemContext";
        }

        protected override void Seed(StudentSystemContext context)
        {
            Random random = new Random();

            // Add Students
            if (!context.Students.Any())
            {
                context.Students.Add(new Student
                {
                    Name = "Pesho",
                    PhoneNumber = "004-331-221555",
                    RegistrationDate = new DateTime(2015, 10, 10),
                    Birthday = new DateTime(1992, 09, 02)
                });

                context.Students.Add(new Student
                {
                    Name = "Gosho",
                    PhoneNumber = "115-321-261955",
                    RegistrationDate = DateTime.Now,
                    Birthday = new DateTime(1993, 05, 06)
                });

                context.Students.Add(new Student
                {
                    Name = "Tanq",
                    PhoneNumber = "007-126-22312",
                    RegistrationDate = DateTime.Now,
                    Birthday = new DateTime(1993, 09, 02)
                });

                context.Students.Add(new Student
                {
                    Name = "Sanq",
                    PhoneNumber = "6565699324",
                    RegistrationDate = DateTime.Now,
                    Birthday = new DateTime(1994, 02, 04)
                });

                context.Students.Add(new Student
                {
                    Name = "Pesho",
                    PhoneNumber = "004-331-221555",
                    RegistrationDate = new DateTime(2015, 10, 11),
                    Birthday = new DateTime(1995, 09, 02)
                });

                context.Students.Add(new Student
                {
                    Name = "Toshko",
                    PhoneNumber = "099200110011",
                    RegistrationDate = DateTime.Now,
                    Birthday = new DateTime(1993, 09, 02)
                });

                context.Students.Add(new Student
                {
                    Name = "Kiril",
                    PhoneNumber = "097755669900",
                    RegistrationDate = new DateTime(2015, 09, 17),
                    Birthday = new DateTime(1991, 09, 27)
                });

                context.SaveChanges();
            }

            var students = context.Students.ToList();

            // Add Courses
            if (!context.Courses.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    var studentsToAdd = students.OrderBy(s => random.Next()).Take(2).ToList();

                    context.Courses.Add(new Course
                    {
                        Name = "Course N" + i,
                        Description = "Course N" + i + "Description N" + i,
                        StartDate = new DateTime(2015, i, 01),
                        EndDate = new DateTime(2015, i + 1, 21),
                        Price = 50 * random.Next(50, i * 50),
                        Students = studentsToAdd
                    });
                }

                context.SaveChanges();
            }

            var courses = context.Courses.ToList();

            // Add Resources
            if (!context.Resources.Any())
            {
                Array resourceTypeValues = Enum.GetValues(typeof(TypeOfResource));

                for (int i = 1; i <= 20; i++)
                {
                    context.Resources.Add(new Resource
                    {
                        Name = "Resource N" + i,
                        TypeOfResource = (TypeOfResource)resourceTypeValues.GetValue(random.Next(resourceTypeValues.Length)),
                        URL = "www.ResourceN" + i + ".com",
                        CourseId = courses[random.Next(0, courses.Count)].Id
                    });
                }

                context.SaveChanges();
            }

            // Add homeworks:
            if (!context.Homeworks.Any())
            {
                Array homeworkTypeValues = Enum.GetValues(typeof(ContentType));

                for (int i = 1; i <= 30; i++)
                {
                    context.Homeworks.Add(new Homework
                    {
                        Content = "Homework N" + i,
                        ContentType = (ContentType)homeworkTypeValues.GetValue(random.Next(homeworkTypeValues.Length)),
                        SubmissionDate = DateTime.Now.AddDays(i),
                        StudentId = students[random.Next(students.Count())].Id,
                        CourseId = courses[random.Next(courses.Count())].Id
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
