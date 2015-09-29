namespace _01.Tower_of_Hanoi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TowerOfHanoi
    {
        private static int steps = 0;

        private static Stack<int> sourceRod;
        private static Stack<int> destinationRod = new Stack<int>();
        private static Stack<int> spareRod = new Stack<int>();

        public static void Main(string[] args)
        {
            Console.Write("Discs count: ");
            int discsCount = int.Parse(Console.ReadLine());
            sourceRod = new Stack<int>(Enumerable.Range(1, discsCount).Reverse());
            MoveDiscs(discsCount, sourceRod, destinationRod, spareRod);
        }

        private static void MoveDiscs(int bottomDisc, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisc == 1)
            {
                destination.Push(source.Pop());
                PrintRods();
            }
            else
            {
                MoveDiscs(bottomDisc - 1, source, spare, destination);
                destination.Push(source.Pop());
                PrintRods();
                MoveDiscs(bottomDisc - 1, spare, destination, source);
            }
        }

        private static void PrintRods()
        {
            Console.WriteLine("Step #" + ++steps);
            Console.WriteLine("Source: {0}", string.Join(", ", sourceRod.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", destinationRod.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(", ", spareRod.Reverse()));
            Console.WriteLine();
        }
    }
}
