namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    
    public class LongestSubsequence
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
            
            List<int> longestSeq = FindLongestSequence(nums);

            longestSeq.ForEach(Console.WriteLine);
        }

        static List<int> FindLongestSequence(List<int> list)
        {
            List<int> currentSequence = new List<int>();

            int index = 0;
            int currentSeqLength = 0;
            int bestLength = 0;
            int current;
            int? last = null;

            for (int i = 0; i < list.Count; i++)
            {
                current = list[i];

                if (last == current)
                {
                    currentSeqLength++;
                }
                else
                {
                    currentSeqLength = 0;
                }

                if (currentSeqLength > bestLength)
                {
                    bestLength = currentSeqLength;
                    index = i;
                }

                last = current;
            }

            for (int i = index; i > index - bestLength - 1; i--)
            {
                currentSequence.Add(list[i]);
            }
            
            return currentSequence;
        }
    }
}
