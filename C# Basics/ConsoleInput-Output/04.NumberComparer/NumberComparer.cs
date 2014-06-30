using System;
namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            // Write a program that gets two numbers from the console and prints the greater of them. 
            // Try to implement this without if statements.

            Console.Write("first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("greater: " + (Math.Max(firstNumber, secondNumber)));
    
        }
    }
}
