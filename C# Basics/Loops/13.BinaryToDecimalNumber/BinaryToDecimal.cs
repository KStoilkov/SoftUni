using System;
using System.Linq;
using System.Collections.Generic;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimal
    {
        static void Main()
        {
            // Using loops write a program that converts a binary integer number to its decimal form. 
            // The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

            Console.Write("Binary: ");
            string input = Console.ReadLine();
            char[] inputt = input.ToCharArray();
            List<int> holder = new List<int>();

            for (int i = 0; i < inputt.Length; i++)
            {
                switch (inputt[i])
                {
                    case '0': holder.Add(0); break;
                    case '1': holder.Add(1); break;
                    default: break;
                }
            }
            
            int[] inputed = holder.ToArray();
            long pow = 0;
            long result = 0;

            for (int i = 0; i < inputed.Length; i++)
            {
                pow = inputed[i] * (int)Math.Pow(2, inputed.Length - i - 1);
                result += pow;
            }

            Console.WriteLine("Decimal: " + result);
        }
    }
}
