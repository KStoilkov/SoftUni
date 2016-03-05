namespace _01.ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;

    public class ReverseNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Stack<string> nums = new Stack<string>();
            foreach (var item in splitedInput)
            {
                nums.Push(item);
            }

            while (nums.Count > 0)
            {
                Console.WriteLine(nums.Pop());
            }
        }
    }
}
