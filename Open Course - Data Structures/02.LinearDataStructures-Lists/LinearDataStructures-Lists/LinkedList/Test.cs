namespace LinkedList
{
    using System;

    public class Test
    {
        static void Main()
        {
            var ll = new LinkedList<int>();

            // Add elements
            ll.Add(5);
            ll.Add(3);
            ll.Add(2);
            var llElement = ll.Add(2);
            ll.Add(3);
            ll.Add(12);
            ll.Add(2);

            // Print elements
            Console.WriteLine("Print elements");
            Console.WriteLine(string.Join(" ", ll));

            // Remove elements
            ll.Remove(1);
            ll.Remove(1);
            ll.Remove(2);

            Console.WriteLine("After removing");
            Console.WriteLine(string.Join(" ", ll));

            // Test methods
            Console.WriteLine("First Index Of element with value " + llElement.Value);
            Console.WriteLine(ll.FirstIndexOf(llElement));

            Console.WriteLine("Last Index Of element with value " + llElement.Value);
            Console.WriteLine(ll.LastIndexOf(llElement));

            Console.WriteLine("Count: " + ll.Count);
        }
    }
}
