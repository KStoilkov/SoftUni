namespace _02.CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    public class CalculateSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            int timesPrinted = 0;
            while (timesPrinted < 50)
            {
                int num = queue.Dequeue();

                queue.Enqueue(num + 1);
                queue.Enqueue(2 * num + 1);
                queue.Enqueue(num + 2);

                Console.Write(num + ", ");
                timesPrinted++;
            }
        }
    }
}
