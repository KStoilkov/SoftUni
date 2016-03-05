namespace _05.LinkedStack
{
    using System;

    public class LinkedStack<T>
    {
        private Node<T> firstNode;
        
        public int Count { get; private set; }

        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }

        public T Pop()
        {
            var element = this.firstNode;

            if (element == null)
            {
                throw new IndexOutOfRangeException();
            }

            this.firstNode = this.firstNode.NextNode;
            this.Count--;

            return element.Value;
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];

            var element = this.firstNode;
            int count = this.Count - 1;

            while (element != null)
            {
                arr[count] = element.Value;
                element = element.NextNode;
                count--;
            }

            return arr;
        }

        private class Node<T>
        {
            public Node(T value, Node<T> nextNode = null)
            {
                this.Value = value;
                this.NextNode = nextNode;
            }

            public T Value { get; set; }

            public Node<T> NextNode { get; set; }
        }
    }
}
