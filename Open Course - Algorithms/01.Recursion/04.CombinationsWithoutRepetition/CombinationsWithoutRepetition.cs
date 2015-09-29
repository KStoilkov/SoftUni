namespace _04.CombinationsWithoutRepetition
{
    using System;
    using System.Collections.Generic;

    public class CombinationsWithoutRepetition
    {
        private const int Start = 1;
        private static List<int> combinations = new List<int>();

        public static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());

            Loop(n, k, Start);
        }

        private static void Loop(int n, int k, int start)
        {
            if (k == 0)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                if (combinations.Contains(i))
                {
                    continue;
                }

                combinations.Add(i);
                Loop(n, k - 1, i);
                combinations.RemoveAt(combinations.Count - 1);
            }
        }
    }
}
