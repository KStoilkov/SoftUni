namespace ReversedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ReversedList<T> : IEnumerable<T>
    {
        private T[] arr;
        private int startCapacity = 4;

        public ReversedList()
        {
            this.arr = new T[startCapacity];
            this.Capacity = startCapacity;
        }

        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public void Add(T item)
        {
            if (this.Count + 1 > this.arr.Length)
            {
                this.Capacity = this.Capacity * 2;
                T[] newArr = new T[this.Capacity];
                Array.Copy(this.arr, 0, newArr, 1, this.arr.Length);
                newArr[0] = item;
                this.arr = newArr;
            }
            else
            {
                for (int i = this.Count; i > 0; i--)
                {
                    this.arr[i] = this.arr[i - 1];
                }
                this.arr[0] = item;
            }

            this.Count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.Count - 1)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.arr[index];
            }
            private set
            {
                this.arr[index] = value;
            }
        }

        public void Remove(int index)
        {
            if (index < 0 && index > this.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < this.Count; i++)
            {
                if (i + 1 == this.Count)
                {
                    this.arr[i] = default(T);
                }

                this.arr[i] = this.arr[i + 1];
            }

            this.Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return this.GetEnumerator();
        }
    }
}
