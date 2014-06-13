using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            // Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two 
            // floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal 
            // if they are more closely to each other than a fixed constant eps.

            Console.Write("First number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            bool comparing = (Math.Abs(firstNumber - secondNumber) < 0.000001);

            if (comparing)
            {
                Console.WriteLine(comparing + " " + "The numbers are equal with a precision of 0.000001");
            }
            else
            {
                Console.WriteLine(comparing + " " + "The numbers are not equal with a precision of 0.000001");
            }
        }
    }
}
