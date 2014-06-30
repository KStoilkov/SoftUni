using System;

namespace _07.SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
            // Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prdoubles their sum. 

            Console.WriteLine("Please enter a five digits separated by a space:");
            string numbers = Console.ReadLine();
            string[] splitNums = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double num1 = double.Parse(splitNums[0]);
            double num2 = double.Parse(splitNums[1]);
            double num3 = double.Parse(splitNums[2]);
            double num4 = double.Parse(splitNums[3]);
            double num5 = double.Parse(splitNums[4]);
            double sum = num1 + num2 + num3 + num4 + num5;
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}",splitNums[0], splitNums[1], splitNums[2], splitNums[3], splitNums[4], sum);
        }
    }
}
