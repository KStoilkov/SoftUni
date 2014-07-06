using System;

namespace _07.Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            // Write a program that enters 3 real numbers and prdoubles them sorted in descending order. 
            // Use nested if statements. Don’t use arrays and the built-in sorting functionality. 

            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.Write(a + " ");
                if (b > c)
                {
                    Console.Write(b + " " + c);
                }
                else
                {
                    Console.Write(c + " " + b);
                }
            }
            else if (b > a && b > c)
            {
                Console.Write(b + " ");
                if (a > c)
                {
                    Console.Write(a + " " + c);
                }
                else
                {
                    Console.Write(c + " " + a);
                }
            }
            else if (c > b && c > a)
            {
                Console.Write(c + " ");
                if (b > a)
                {
                    Console.Write(b + " " + a);
                }
                else
                {
                    Console.Write(b + " " + a);
                }
            }
            Console.WriteLine();
        }
    }
}
