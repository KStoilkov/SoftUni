using System;

namespace _01.School
{
    using System.Collections.Generic;

    class Test
    {
        public static void Main() { 
            
            // Creating Students
            Student gosho = new Student("Gosho", 123456);
            Student petko = new Student("Petko", 432523, "Excellent grade");
            Student toshko = new Student("Toshko", 876981);
            Student kircho = new Student("Kircho", 987093);
            Student galq = new Student("Galq", 654127);
            Student valq = new Student("Valq", 986123);

            List<Student> listOfStudents1 = new List<Student> { gosho, petko };
            List<Student> listOfStudents2 = new List<Student> { toshko, kircho };
            List<Student> listOfStudents3 = new List<Student> { galq, valq };

            // Creating Disciplines
            Discipline csharp = new Discipline("C#", 8, listOfStudents1);
            Discipline js = new Discipline("JavaScript", 6, listOfStudents2, "Amazing course");
            Discipline java = new Discipline("Java", 9, listOfStudents3);

            List<Discipline> listOfDisciplines1 = new List<Discipline> { csharp, java};
            List<Discipline> listOfDisciplines2 = new List<Discipline> { csharp, js};
            List<Discipline> listOfDisciplines3 = new List<Discipline> { js, java};

            // Creating Teachers
            Teacher mitko = new Teacher("Mitko", listOfDisciplines1, "C# Master");
            Teacher pesho = new Teacher("Pesho", listOfDisciplines2);
            Teacher valio = new Teacher("Valio", listOfDisciplines3);

            List<Teacher> listOfTeachers1 = new List<Teacher> { mitko, pesho};
            List<Teacher> listOfTeachers2 = new List<Teacher> { valio, pesho };
            List<Teacher> listOfTeachers3 = new List<Teacher> { mitko, valio };

            // Creating Classes
            Class first = new Class(listOfTeachers1, "Class 10a");
            Class second = new Class(listOfTeachers2, "Class 10b", "bad discipline");
            Class third = new Class(listOfTeachers3, "Class 10c");

            List<Class> classes = new List<Class> { first, second, third };

            // Creating School
            School softSchool = new School(classes);

            Console.WriteLine(softSchool);
        }
    }
}
