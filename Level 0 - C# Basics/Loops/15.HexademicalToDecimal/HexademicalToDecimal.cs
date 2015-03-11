using System;
using System.Collections.Generic;

namespace _15.HexademicalToDecimal
{
    class HexademicalToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine().ToUpper();

            char[] inputed = input.ToCharArray();

            List<int> arrList = new List<int>();

            long result = 0;
            for (int i = 0; i < inputed.Length; i++)
            {
                switch (inputed[i])
                {
                    case '0': arrList.Add(0); break;
                    case '1': arrList.Add(1); break;
                    case '2': arrList.Add(2); break;
                    case '3': arrList.Add(3); break;
                    case '4': arrList.Add(4); break;
                    case '5': arrList.Add(5); break;
                    case '6': arrList.Add(6); break;
                    case '7': arrList.Add(7); break;
                    case '8': arrList.Add(8); break;
                    case '9': arrList.Add(9); break;
                    case 'A': arrList.Add(10); break;
                    case 'B': arrList.Add(11); break;
                    case 'C': arrList.Add(12); break;
                    case 'D': arrList.Add(13); break;
                    case 'E': arrList.Add(14); break;
                    case 'F': arrList.Add(15); break;
                    default: break;
                }
            }

            int[] gatherer = arrList.ToArray();

            long pow = 0;
            for (int i = 0; i < gatherer.Length; i++)
            {
                pow = (long)(Math.Pow(16, gatherer.Length - i - 1));
                result += gatherer[i] * pow;        
            }
            Console.WriteLine(result);
            
        }
    }
}
