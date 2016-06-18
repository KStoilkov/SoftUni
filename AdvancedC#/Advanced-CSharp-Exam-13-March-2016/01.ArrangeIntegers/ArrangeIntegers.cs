using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ArrangeIntegers
{
    class ArrangeIntegers
    {
        static void Main(string[] args)
        {
            string[] letters = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            List<string> inputLetters = TransformToLetters(letters, input);

            var sorted = inputLetters
                .Select((x, i) => new KeyValuePair<string, int>(x, i))
                .OrderBy(x => x.Key)
                .ToList();
            
            List<int> idx = sorted.Select(x => x.Value).ToList();
            List<string> result = new List<string>();
            foreach (int num in idx)
            {
                result.Add(input[num]);
            }

            Console.WriteLine(String.Join(", ", result));
        }

        private static List<string> TransformToLetters(string[] lettersArr, string[] inputLetters)
        {
            List<string> letters = new List<string>();
            foreach (string inputNum in inputLetters)
            {
                List<string> currentNum = new List<string>();
                for (int i = 0; i < inputNum.Length; i++)
                {
                    int num = int.Parse(inputNum[i].ToString());
                    currentNum.Add(lettersArr[num]);
                }
                letters.Add(String.Join("-", currentNum));
            }

            return letters;
        }
    }
}
