namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            Quicksort(collection, 0, collection.Count - 1);
        }       

        private void Quicksort(List<T> array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int pivotIndex = start;
            int storeIndex = start + 1;

            for (int i = start + 1; i <= end; i++)
            {
                if (array[i].CompareTo(array[pivotIndex]) < 0)
                {
                    Swap(ref array, i, storeIndex);
                    storeIndex++;
                }
            }

            storeIndex--;

            Swap(ref array, pivotIndex, storeIndex);
            
            Quicksort(array, start, storeIndex - 1);
            Quicksort(array, storeIndex + 1, end);
        }

        private void Swap(ref List<T> numbers, int a, int b)
        {
            T temp = numbers[a];
            numbers[a] = numbers[b];
            numbers[b] = temp;
        }
    }
}
