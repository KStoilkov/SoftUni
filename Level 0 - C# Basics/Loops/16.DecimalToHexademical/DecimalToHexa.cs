using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.DecimalToHexademical
{
    class DecimalToHexa
    {
        static void Main()
        {
            // Using loops write a program that converts an integer number to its hexadecimal representation. 
            // The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 
            Console.Write("Decimal: ");
            long input = long.Parse(Console.ReadLine());

            List<long> myList = new List<long>();

            long holder = 0;

            while (input > 0)
            {
                holder = input % 16;
                myList.Add(holder);
                if (holder != 0)
                {
                    input = (input - 1) / 16;
                }
                else
                {
                    input /= 16;
                }

            }

            long[] temporary = myList.ToArray();
            string result = "";

            for (int i = temporary.Length - 1; i >= 0; i--)
            {
                switch (temporary[i])
                {
                    case 0: result += "0"; break;
                    case 1: result += "1"; break;
                    case 2: result += "2"; break;
                    case 3: result += "3"; break;
                    case 4: result += "4"; break;
                    case 5: result += "5"; break;
                    case 6: result += "6"; break;
                    case 7: result += "7"; break;
                    case 8: result += "8"; break;
                    case 9: result += "9"; break;
                    case 10: result += "A"; break;
                    case 11: result += "B"; break;
                    case 12: result += "C"; break;
                    case 13: result += "D"; break;
                    case 14: result += "E"; break;
                    case 15: result += "F"; break;
                    default: break;
                }
            }
            Console.WriteLine("Hexademical: " + result);
        }
    }
}
