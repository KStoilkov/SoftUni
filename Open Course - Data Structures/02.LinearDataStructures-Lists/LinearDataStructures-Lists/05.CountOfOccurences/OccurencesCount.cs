namespace _05.CountOfOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OccurencesCount
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] nums = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var occurencesCount = CountOccurences(nums);

            foreach (var occurence in occurencesCount)
            {
                Console.WriteLine($"{occurence.Key} -> {occurence.Value} times");
            }
        }

        static SortedDictionary<int, int> CountOccurences(int[] nums)
        {
            var occurencesCount = new SortedDictionary<int, int>();
            bool[] marked = new bool[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (!marked[i])
                {
                    int current = nums[i];

                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (current == nums[j])
                        {
                            if (!occurencesCount.ContainsKey(current))
                            {
                                occurencesCount.Add(current, 1);
                            }
                            else
                            {
                                occurencesCount[current]++;
                            }

                            marked[j] = true;
                        }
                    }
                }
            }

            return occurencesCount;
        }
    }
}
