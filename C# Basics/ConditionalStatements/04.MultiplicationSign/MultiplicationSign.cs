using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            // Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
            // Use a sequence of if operators. 
            Console.Write("a: ");
            double a= double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (a < 0)
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine("result: -");
                    }
                    else
                    {
                        Console.WriteLine("result: +");
                    }
                }
                else
                {
                    if (c < 0)
                    {
                        Console.WriteLine("result: -");
                    }
                    else
                    {
                        Console.WriteLine("result: +");
                    }
                }
            }
            else if (a > 0)
            {
                if (b < 0)
                {
                    if (c < 0)
                    {
                        Console.WriteLine("result: +");
                    }
                    else
                    {
                        Console.WriteLine("result: -");
                    }
                }
                else
                {
                    if (c < 0)
                    {
                        Console.WriteLine("result: -");
                    }
                    else
                    {
                        Console.WriteLine("result: +");
                    }
                }
            }
            else if ((a == 0) || (b == 0) || (c == 0))
            {
                Console.WriteLine("result: 0");
            }


        }
    }
}
