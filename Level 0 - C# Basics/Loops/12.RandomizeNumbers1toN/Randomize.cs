using System;
using System.Linq;
using System.Collections.Generic;

namespace _12.RandomizeNumbers1toN
{
    class Randomize
    {
        static void Main()
        {
            // Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 

            int n = int.Parse(Console.ReadLine());

            int[] gatherer = new int[n];

            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                gatherer[counter] = i;
                counter++;
            }

            int createdNumber = 0;

            int[] randomGatherer = new int[n];

            Random generator = new Random();

            for (int i = 0; i < gatherer.Length; i++)
            {
            repeater:
                createdNumber = generator.Next(1, gatherer.Length + 1);
                if (randomGatherer.Contains(createdNumber))
                {
                    goto repeater;
                }
                else
                {
                    randomGatherer[i] = createdNumber;               
                }
            }

            for (int i = 0; i < randomGatherer.Length; i++)
            {
                Console.Write(randomGatherer[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
