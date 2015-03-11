using System;

namespace _08.SquareRoot
{
    class SquareRoots
    {
        static void Main()
        {
            //Problem 8.	Square Root
            //Create a console application that calculates and prints the square root of the number 12345. 
            //Find in Internet “how to calculate square root in C#”.

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            double squareRootNumber = Math.Sqrt(number);
            Console.WriteLine(squareRootNumber);

        }
    }
}
