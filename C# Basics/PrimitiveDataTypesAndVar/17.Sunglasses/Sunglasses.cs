using System;

namespace _17.Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', n * 2));
            Console.WriteLine();
            
            for (int i = 0; i < n - 2; i++)
            {
                
                Console.Write(new string('*', 1));
                Console.Write(new string('/', n*2-2));
                Console.Write(new string('*', 1));

                if (i == (n-2)/2)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n)); 
                }

                Console.Write(new string('*', 1));
                Console.Write(new string('/', n * 2 - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine();
                
            }

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', n * 2));
            Console.WriteLine();
        }
    }
}
