using System;
using System.Linq;
using System.Collections.Generic;

namespace _14.DecimalToBinaryNumber
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Decimal: ");
            int input = int.Parse(Console.ReadLine());

            List<int> arrList = new List<int>();

            int holder = 0;

            while (input > 0)
            {
                holder = input % 2;
                arrList.Add(holder);
                if (holder == 1)
                {
                    input = (input - 1) / 2;
                }
                else
                {
                    input /= 2;
                }
                
            }
            int[] binaryResult = arrList.ToArray();

            Console.Write("Binary: ");
            for (int i = binaryResult.Length - 1; i >= 0; i--)
            {
                Console.Write(binaryResult[i]);
            }
            Console.WriteLine();
        }

    }
}
