namespace _02.AsynchronousTimer
{
    using System;

    class Test
    {
        static void Main()
        {
            AsyncTimer asyncTimer = new AsyncTimer(TestMethod, 2000, 20);
            asyncTimer.Start();
        }

        public static void TestMethod()
        {
            Console.WriteLine("Hey!");
        }
    }
}
