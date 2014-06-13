using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class isoscelesTriangle
    {
        static void Main()
        {
            // Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
            //    ©
            //   © ©
            //  ©   ©
            // © © © ©
            // Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 
            // and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, 
            // regardless of how much effort you put to fix it.



            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Enter a lenght for a triangle: ");
            int cLength = int.Parse(Console.ReadLine());

            Console.WriteLine();
            int emptySpaceInside = 1;
            int emptySpaceOutside = cLength - 2;

            Console.WriteLine(new string(' ', cLength - 1) + '\u00A9' + (new string(' ', cLength)));

            for (int i = 0; i < cLength - 2; i++)
            {
                Console.Write(new string(' ', emptySpaceOutside));
                Console.Write('\u00A9');

                Console.Write(new string(' ', emptySpaceInside));
                Console.WriteLine('\u00A9');

                emptySpaceInside += 2;
                emptySpaceOutside--;
            }

            for (int i = 0; i < cLength; i++)
            {
                Console.Write('\u00A9');
                Console.Write(' ');
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
