using System;

namespace _09.PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            //Problem 9.	Print a Sequence
            //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

            for (int i = 2; i < 13; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                if (i % 2 == 1)
                {
                    Console.Write("-" + i + " ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
