using System;

namespace _03.GenericList
{
    using System.Text;

    public class GenericList<T>
    {
        private T[] elements;
        private const int DefaultCapacity = 16;
        private int elementsCount = 0;

        public int ElementsCount
        {
            get { return this.elementsCount; }
        }

        public GenericList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
        }

        public void Add(T element)
        {
            if (this.elements.Length == this.ElementsCount)
            {
                T[] newGenericList = new T[this.ElementsCount * 2];

                for (int i = 0; i < this.elements.Length; i++)
                {
                    newGenericList[i] = this.elements[i];
                }

                this.elements = newGenericList;
            }
            this.elements[this.ElementsCount] = element;
            this.elementsCount++;
        }

        public T ElementAtIndex(int index)
        {
            return this.elements[index];
        }

        public void Remove(int index)
        {
            T[] newGenericList = new T[this.elements.Length];
            int indexCounter = 0;

            for (int i = 0; i < this.elements.Length; i++)
            {
                if (i != index)
                {
                    newGenericList[indexCounter] = this.elements[i];
                    indexCounter++;
                }
            }

            this.elements = newGenericList;
            this.elementsCount--;
        }

        public void Insert(T element, int index)
        {
            T[] newGenericList = new T[this.elements.Length + 1];
            int indexCounter = 0;

            for (int i = 0; i < this.elements.Length; i++)
            {
                if (i != index)
                {
                    newGenericList[i] = this.elements[indexCounter];
                    indexCounter++;
                }
                else 
                {
                    newGenericList[i] = element;
                }
            }

            this.elements = newGenericList;
            this.elementsCount++;
        }

        public void ClearList()
        {
            this.elements = new T[DefaultCapacity];
        }

        public void FindElementIndex(T element)
        {
            bool isFound = false;

            for (int i = 0; i < this.elements.Length; i++)
            {
                if (element.Equals(this.elements[i]))
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Element : " + element + ", doesn't exist.");
            }
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (element.Equals(this.elements[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static T Min<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) > 0)
            {
                return second;
            }

            return first;
        }

        public static T Max<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }

            return second;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.ElementsCount; i++)
            {
                result.AppendLine(this.elements[i].ToString());
            }

            return result.ToString();
        }
    }
}
