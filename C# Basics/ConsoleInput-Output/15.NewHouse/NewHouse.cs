using System;

namespace _15.NewHouse
{
    class NewHouse
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int n1 = (n - 1) / 2;
            int n2 = 1;
            int n3 = n1 + 1;

            for (int i = 0; i <= n3 + n; i++)
            {
                if (i < n3)
                {
                    Console.Write(new string('-', n1));
                    Console.Write(new string('*', n2));
                    Console.Write(new string('-', n1));
                    Console.WriteLine();
                    n1--;
                    n2 += 2;
                }
                if (i > n3)
                {
                    Console.Write(new string('|',1));
                    Console.Write(new string('*',n-2));
                    Console.Write(new string('|', 1));
                    Console.WriteLine();
                }
                
            }
        }
    }
}
