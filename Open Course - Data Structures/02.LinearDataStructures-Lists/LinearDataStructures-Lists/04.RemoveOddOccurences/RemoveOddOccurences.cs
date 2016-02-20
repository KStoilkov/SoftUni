namespace _04.RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;
    
    public class RemoveOddOccurences
    {
        static void Main()
        {
            List<int> nums = new List<int>();

            string input = Console.ReadLine();
            string[] splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var num in splitedInput)
            {
                nums.Add(int.Parse(num));
            }

            List<int> newNums = RemoveOccurences(nums);

            newNums.ForEach(Console.WriteLine);
        }

        static List<int> RemoveOccurences(List<int> nums)
        {
            List<int> evenOccurences = new List<int>();
            bool[] marked = new bool[nums.Count];

            for (int i = 0; i < nums.Count; i++)
            {
                if (!marked[i])
                {
                    int current = nums[i];
                    List<int> occurencesIndeces = new List<int>();

                    for (int j = 0; j < nums.Count; j++)
                    {
                        if (!marked[j] && current == nums[j])
                        {
                            occurencesIndeces.Add(j);
                            marked[j] = true;
                        }
                    }
                    
                    if (occurencesIndeces.Count % 2 == 0)
                    {
                        foreach (int index in occurencesIndeces)
                        {
                            evenOccurences.Add(nums[index]);
                        }
                    }
                }
            }

            return evenOccurences;
        }
    }
}
