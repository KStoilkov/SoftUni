using System;

namespace _17.Sunglasses2
{
    class Sunglasses2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.Write(new string('*', n * 2));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', n * 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write(new string('*', 1));

                    if (i == ((n % 2) + ((n - 1) / 2)) - 1)
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
            }
        }
    }
}
