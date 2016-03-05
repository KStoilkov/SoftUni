using System;

namespace _03.ImplementArrayBasedStack
{
    public class ArrayBasedStack<T>
    {
        private const int InitialCapacity = 16;
        private T[] elements;

        public ArrayBasedStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; set; }

        public void Push(T element)
        {
            if (this.Count + 1 > this.elements.Length)
            {
                this.Grow();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            var element = this.elements[this.Count - 1];
            this.Count--;

            return element;
        }

        public T[] ToArray()
        {
            var newArr = new T[this.Count];
            Array.Copy(this.elements, newArr, this.Count);

            return newArr;
        }

        private void Grow()
        {
            var newArr = new T[2 * this.elements.Length];
            Array.Copy(this.elements, newArr, this.Count);

            this.elements = newArr;
        }
    }
}
