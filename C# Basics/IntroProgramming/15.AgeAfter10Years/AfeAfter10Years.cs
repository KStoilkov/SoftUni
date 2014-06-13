using System;

namespace _15.AgeAfter10Years
{
    class AfeAfter10Years
    {
        static void Main()
        {
            //Age after 10 Years
            //Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

            Console.Write("Your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("You age after 10 years: " + (age + 10));
        }
    }
}
