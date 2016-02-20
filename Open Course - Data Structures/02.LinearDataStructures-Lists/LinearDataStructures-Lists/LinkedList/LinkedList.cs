namespace LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        private ListNode<T> head;
        private ListNode<T> current;

        public int Count { get; set; }

        public ListNode<T> Add(T item)
        {
            var newNode = new ListNode<T>(item);

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                this.current.Next = newNode;
            }

            this.current = newNode;

            this.Count++;

            return newNode;
        }

        public void Remove(int index)
        {
            if (index < 0 && index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                this.head = this.head.Next;
            }
            else 
            {
                var node = this.GetByIndex(index - 1);
                if (index == this.Count - 1)
                {
                    node.Next = null;
                }
                else
                {
                    node.Next = node.Next.Next;
                }    
            }

            this.Count--;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            var current = this.head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private ListNode<T> GetByIndex(int index)
        {
            int i = 0;
            var current = this.head;
            while (current != null)
            {
                if (i == index)
                {
                    return current;
                }

                i++;
                current = current.Next;
            }

            return null;
        }

        public int FirstIndexOf(ListNode<T> item)
        {
            int index = 0;
            var current = this.head;
            while (current != null)
            {
                if (item.Value.Equals(current.Value))
                {
                    return index;
                }

                index++;
                current = current.Next;
            }

            return -1;
        }

        public int LastIndexOf(ListNode<T> item)
        {
            int index = 0;
            int lastIndex = -1;
            var current = this.head;
            while (current != null)
            {
                if (item.Value.Equals(current.Value))
                {
                    lastIndex = index;
                }

                index++;
                current = current.Next;
            }

            return lastIndex;
        }
    }
}
