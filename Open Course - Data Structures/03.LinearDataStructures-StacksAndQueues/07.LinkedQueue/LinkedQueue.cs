namespace _07.LinkedQueue
{
    using System;

    public class LinkedQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;

        public void Enqueue(T element)
        {
            var node = new QueueNode<T>(element);

            if (this.Count == 0)
            {
                this.head = node;
            }
            else if (this.Count == 1)
            {
                this.head.NextNode = node;
                node.PrevNode = this.head;
            }
            else
            {
                this.tail.NextNode = node;
                node.PrevNode = this.tail;
            }
            this.tail = node;
            
            this.Count++;
        }

        public int Count { get; set; }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }

            T element = this.head.Value;
            this.head = this.head.NextNode;
            this.Count--;

            return element;
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];

            var element = this.head;
            int count = 0;

            while (element != null)
            {
                arr[count] = element.Value;
                element = element.NextNode;
                count++;
            }

            return arr;
        }

        private class QueueNode<T>
        {
            public QueueNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }

            public QueueNode<T> NextNode { get; set; }

            public QueueNode<T> PrevNode { get; set; }
        }
    }
}
