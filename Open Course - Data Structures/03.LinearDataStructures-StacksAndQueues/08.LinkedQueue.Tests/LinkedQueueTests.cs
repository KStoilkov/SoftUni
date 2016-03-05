namespace _08.LinkedQueue.Tests
{
    using _07.LinkedQueue;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class LinkedQueueTests
    {
        [TestMethod]
        public void EnqueueDequeueElements_ShouldWorkCorrectly()
        {
            var stack = new LinkedQueue<int>();

            Assert.AreEqual(0, stack.Count);

            int num = 5;
            stack.Enqueue(num);
            Assert.AreEqual(1, stack.Count);

            var element = stack.Dequeue();
            Assert.AreEqual(num, element);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void EnqueueDequeue1000Elements_ShouldWorkCorrectly()
        {
            var stack = new LinkedQueue<string>();

            for (int i = 0; i < 1000; i++)
            {
                stack.Enqueue(i.ToString());
            }

            Assert.AreEqual(1000, stack.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DequeueFromEmptyStack_ShouldThrowException()
        {
            var stack = new LinkedQueue<int>();

            var element = stack.Dequeue();
        }

        [TestMethod]
        public void EnqueueDequeueMoreItems_ShouldWorkCorrectly()
        {
            var stack = new LinkedQueue<int>();

            Assert.AreEqual(0, stack.Count);

            stack.Enqueue(10);
            Assert.AreEqual(1, stack.Count);
            stack.Enqueue(15);
            Assert.AreEqual(2, stack.Count);

            var element = stack.Dequeue();
            Assert.AreEqual(10, element);
            Assert.AreEqual(1, stack.Count);

            var anotherElement = stack.Dequeue();
            Assert.AreEqual(15, anotherElement);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void ToArray_ShouldReturnArray()
        {
            var stack = new LinkedQueue<int>();

            stack.Enqueue(3);
            stack.Enqueue(5);
            stack.Enqueue(-2);
            stack.Enqueue(7);

            var arr = stack.ToArray();
            CollectionAssert.AreEqual(new int[] { 3, 5, -2, 7 }, arr);
        }

        [TestMethod]
        public void EmptyStackToArray_ShouldReturnEmptyArray()
        {
            var stack = new LinkedQueue<int>();

            var arr = stack.ToArray();
            Assert.AreEqual(0, arr.Length);
        }
    }
}
