﻿namespace _01.Permutations
{
    using System;
    using System.Linq;

    public class Permutations
    {
        private static int countOfPermutations = 0;

        private static int[] array;

        public static void Main()
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            array = Enumerable.Range(1, n).ToArray();

            Permute(array);

            Console.WriteLine("Total permutations: " + countOfPermutations);
        }

        private static void Permute(int[] array, int startIndex = 0)
        {
            if (startIndex >= array.Length - 1)
            {
                Console.WriteLine(string.Join(", ", array));
                countOfPermutations++;
            }
            else
            {
                for (int i = startIndex; i < array.Length; i++)
                {
                    Swap(ref array[startIndex], ref array[i]);
                    Permute(array, startIndex + 1);
                    Swap(ref array[startIndex], ref array[i]);
                }
            }
        }

        private static void Swap(ref int i, ref int j)
        {
            if (i == j)
            {
                return;
            }

            i ^= j;
            j ^= i;
            i ^= j;
        }
    }
}
