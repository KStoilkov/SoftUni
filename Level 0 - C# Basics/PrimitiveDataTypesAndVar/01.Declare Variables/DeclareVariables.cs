using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            // Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent 
            // the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. 
            // Submit the source code of your Visual Studio project as part of your homework submission.

            sbyte first = -115;
            ushort second = 52130;
            int third = 4825932;
            byte forth = 97;
            short fifth = -10000;

            Console.WriteLine(first + " " + second + " " + third + " " + forth + " " + fifth);
            Console.WriteLine();
        }
    }
}
