namespace SortWords
{
    using System;
    using System.Collections.Generic;

    public class SortWords
    {
        static void Main()
        {
            List<string> nums = new List<string>();

            string input = Console.ReadLine();
            string[] splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(splitedInput);

            Console.WriteLine(string.Join(" ", splitedInput));
        }
    }
}
