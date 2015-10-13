namespace _04.GenerateSubsetOfStringArray
{
    using System;
    using System.Linq;

    public class GenerateSubset
    {
        private static int k = 2;
        private static string[] words = { "test", "rock", "fun" };
        private static int[] resultArr = new int[k];

        public static void Main(string[] args)
        {
            GenerateCombinations();
        }

        private static void GenerateCombinations(int index = 0, int start = 0)
        {
            if (index >= k)
            {
                Print();
            }
            else
            {
                for (int i = start; i < words.Length; i++)
                {
                    resultArr[index] = i;
                    GenerateCombinations(index + 1, i + 1);
                }
            }
        }

        private static void Print()
        {
            Console.WriteLine(string.Join(", ", resultArr.Select(i => words[i])));
        }
    }
}
