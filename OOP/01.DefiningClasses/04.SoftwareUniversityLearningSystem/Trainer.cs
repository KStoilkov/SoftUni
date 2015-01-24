﻿namespace _04.SoftwareUniversityLearningSystem
{
    using System;

    public class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("The course " + courseName + " has been created.");
        }
    }
}
