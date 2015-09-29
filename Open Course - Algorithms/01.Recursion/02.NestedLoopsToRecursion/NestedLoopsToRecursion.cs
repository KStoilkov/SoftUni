namespace _02.NestedLoopsToRecursion
{
    using System;
    using System.Collections.Generic;

    public class NestedLoopsToRecursion
    {
        private static int loopCounter = 0;
        private static List<int> combination = new List<int>(); 

        public static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            GenerateCombinations(n, loopCounter);
        }

        private static void GenerateCombinations(int n, int loopCounter)
        {
            if (loopCounter == n)
            {
                Console.WriteLine(string.Join(" ", combination));
                return;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    combination.Add(i);
                    GenerateCombinations(n, loopCounter + 1);
                    combination.RemoveAt(combination.Count - 1);
                }
            }
        }
    }
}
