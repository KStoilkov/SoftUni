namespace _02.Human__Student_and_Worker
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker("Petko", "Petkov", 500, 7),
                new Worker("Stoicho", "Voivoda", 800, 10),
                new Worker("Kircho", "Kirchov", 1000.50, 8),
                new Worker("Petkan", "Petkanov", 150, 2),
                new Worker("Vlado", "Toshkov", 555, 6),
                new Worker("Toshko", "Vladov", 899.90, 8),
                new Worker("Olga", "Rusova", 566, 6),
                new Worker("Kolio", "Kolqta", 900, 7),
                new Worker("Lili", "Alili", 355, 4),
                new Worker("Fichata", "Kolev", 819, 5)
            };

            List<Student> students = new List<Student>
            {
                new Student("Galq", "Galova", "7500C2"),
                new Student("Filip", "Filipov", "6520C5"),
                new Student("Harry", "Toshkov", "50050C9"),
                new Student("Stoika", "Stoikata", "78015D1"),
                new Student("Hola", "Lola", "70999D5"),
                new Student("Tinka", "Minkova", "12353D7"),
                new Student("Bubka", "Bubena", "65015D9"),
                new Student("Nanko", "Ninov", "85510D0"),
                new Student("Galina", "Galinova", "56060E8"),
                new Student("Grozdana", "Hubenova", "76812E5")
            };

            students = new List<Student>(students.OrderBy(fac => fac.FacultyNumber));
            workers = new List<Worker>(workers.OrderBy(m => m.MoneyPerHour()));

            List<Human> humans = new List<Human>();

            foreach (var student in students)
            {
                humans.Add(student);
            }

            foreach (var worker in workers)
            {
                humans.Add(worker);
            }

            humans = new List<Human>(humans.OrderBy(n => n.FirstName + n.LastName));

            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
