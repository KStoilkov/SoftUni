using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            // Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. 
            // Try to add some number or the null literal to these variables and print the result.

            int? first = null;
            double? second = null;

            Console.WriteLine("Null int: " + first);
            Console.WriteLine("Null double: " + second);

            Console.WriteLine();

            first = first + 5;
            second = second + 12.5;

            Console.WriteLine("After adding 5 to the null int: " + first);
            Console.WriteLine("After adding 12,5 to the null double: " + second);
            Console.WriteLine();

            // :O ?!? 
        }
    }
}
