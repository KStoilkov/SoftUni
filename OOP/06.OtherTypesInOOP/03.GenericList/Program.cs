using System;

namespace _03.GenericList
{
    class Program
    {
        static void Main()
        {
            GenericList<int> myList = new GenericList<int>();
            myList.Add(5);
            myList.Add(1);
            myList.Add(3);
            myList.Add(8);
            Console.WriteLine(myList);

            myList.Remove(2);
            Console.WriteLine(myList);

            myList.Insert(12, 2);
            Console.WriteLine(myList);

            myList.FindElementIndex(1);
            myList.FindElementIndex(17);

            Console.WriteLine(GenericList<int>.Max(5, 12));
            Console.WriteLine(GenericList<int>.Min(123,3));

            bool test = myList.Contains(8);
            bool anotherTest = myList.Contains(26);
            Console.WriteLine(test + " " + anotherTest);
        }
    }
}
