using System;
using System.Linq;

namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        
        static void Main()
        {
            // Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 

            Console.Write("Enter a number[0..999]: ");
            int input = int.Parse(Console.ReadLine());
            while (input < 0 || input > 999)
            {
                Console.Write("Enter a number[0..999]: ");
                input = int.Parse(Console.ReadLine());
            }

            string[] fromZerotoNine = {"zero", "one", "two", "three", "four", "five","six","seven", "eight", "nine" };
            string[] tens = {"ten", "twenty","thirty","forty","fifty" , "sixty","seventy","eighty","ninety"};
            string[] fromElevenToNineteen = {"eleven", "twelve", "thirteen", "fourteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] hundreds = {"One hundred", "Two hundred", "Three hundred", "Four hundred","Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred" };

            if (input >= 0 && input <= 9)
            {
                Console.WriteLine(fromZerotoNine[input].First().ToString().ToUpper() + fromZerotoNine[input].Substring(1));
            }
            else if (input >= 11 && input <= 19)
            {
                Console.WriteLine(fromElevenToNineteen[(input % 10) - 1].First().ToString().ToUpper() + fromElevenToNineteen[(input % 10) - 1].Substring(1));
            }
            else if ((input > 9 && input < 91) && input % 10 == 0)
            {
                Console.WriteLine(tens[input / 10 - 1].First().ToString().ToUpper() + tens[input / 10 - 1].Substring(1));
            }
            else if (input % 100 == 0)
            {
                Console.WriteLine(hundreds[input / 100 - 1]);
            }
            else if ((input >= 0 && input <= 99 ) && input % 10 != 0)
            {
                int tensCalc = (input - (input % 10)) / 10;
                Console.WriteLine(tens[tensCalc - 1].First().ToString().ToUpper() + tens[tensCalc - 1].Substring(1) + " " + fromZerotoNine[input % 10]);
            }
            else
            {
                int hundredsCalc = (input - (input % 100)) / 100;
                int tensCalc1 = (input % 100);
                int tensCalc2 = (tensCalc1 - (tensCalc1 % 10)) / 10;
                int numsCalc = (input % 100) % 10;
                if (tensCalc1 > 10 && tensCalc1 < 20)
                {
                    Console.WriteLine(hundreds[hundredsCalc - 1]+ " and " + fromElevenToNineteen[tensCalc2 - 1]);
                }
                else if (numsCalc == 0)
                {
                    Console.WriteLine(hundreds[hundredsCalc - 1] + " and " + tens[tensCalc2 - 1]);
                }
                else if (tensCalc2 == 0)
                {
                    Console.WriteLine(hundreds[hundredsCalc - 1] + " and " + fromZerotoNine[tensCalc1]);
                }
                else
                {
                    Console.WriteLine(hundreds[hundredsCalc - 1] + " and " + tens[tensCalc2 - 1] + " " + fromZerotoNine[numsCalc]);
                }
            }
        }
    }
}
