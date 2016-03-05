namespace _04.ArrayBasedStack.Tests
{
    using _03.ImplementArrayBasedStack;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void PushPopElements_ShouldPushAndPopCorrectly()
        {
            var stack = new ArrayBasedStack<int>();

            Assert.AreEqual(0, stack.Count);

            int num = 5;
            stack.Push(num);
            Assert.AreEqual(1, stack.Count);

            var element = stack.Pop();
            Assert.AreEqual(num, element);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void PushPop1000Elements_ShouldAuthoGrowCorrectly()
        {
            var stack = new ArrayBasedStack<string>();

            for (int i = 0; i < 1000; i++)
            {
                stack.Push(i.ToString());
            }

            Assert.AreEqual(1000, stack.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void PopFromEmptyStack_ShouldThrowException()
        {
            var stack = new ArrayBasedStack<int>();

            var element = stack.Pop();
        }

        [TestMethod]
        public void PushPopWithGivenCapacity_ShouldWorkCorrectly()
        {
            var stack = new ArrayBasedStack<int>(1);

            Assert.AreEqual(0, stack.Count);

            stack.Push(10);
            Assert.AreEqual(1, stack.Count);
            stack.Push(15);
            Assert.AreEqual(2, stack.Count);

            var element = stack.Pop();
            Assert.AreEqual(15, element);
            Assert.AreEqual(1, stack.Count);

            var anotherElement = stack.Pop();
            Assert.AreEqual(10, anotherElement);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void ToArray_ShouldReturnArray()
        {
            var stack = new ArrayBasedStack<int>();

            stack.Push(3);
            stack.Push(5);
            stack.Push(-2);
            stack.Push(7);

            var arr = stack.ToArray();
            CollectionAssert.AreEqual(new int[] { 3, 5, -2, 7}, arr);
        }

        [TestMethod]
        public void EmtyStackToArray_ShouldReturnEmtyArray()
        {
            var stack = new ArrayBasedStack<int>();

            var arr = stack.ToArray();
            Assert.AreEqual(0, arr.Length);
        }
    }
}
