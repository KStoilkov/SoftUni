using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInString
{
    class QuotesInString
    {
        static void Main()
        {
            // Declare two string variables and assign them with following value:
            // The "use" of quotations causes difficulties.
            // Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.

            string first = "The \"use\" of qutations causes difficulties.";
            string second = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine();

        }
    }
}
