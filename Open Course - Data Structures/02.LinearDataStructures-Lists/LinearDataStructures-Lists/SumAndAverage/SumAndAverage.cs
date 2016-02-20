namespace SumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAndAverage
    {
        static void Main()
        {
            List<int> nums = new List<int>();

            string input = Console.ReadLine();
            string[] splitedInput = input.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var num in splitedInput)
            {
                nums.Add(int.Parse(num));
            }

            int sum = nums.Sum();
            double avg = nums.Average();

            Console.WriteLine($"Sum={sum}; Average={avg}");
        }
    }
}
