namespace ReversedList
{
    using System;

    public class Test
    {
        public static void Main()
        {
            var rl = new ReversedList<int>();

            // Add elements
            rl.Add(1);
            rl.Add(2);
            rl.Add(3);
            rl.Add(4);
            rl.Add(5);
            rl.Add(6);
            rl.Add(7);

            // Print elements
            Console.WriteLine("Print elements");
            Console.WriteLine(string.Join(" ", rl));

            // Remove elements
            rl.Remove(1);
            rl.Remove(3);
            rl.Remove(5);

            Console.WriteLine("After remove");
            Console.WriteLine(string.Join(" ", rl));
        }
    }
}
