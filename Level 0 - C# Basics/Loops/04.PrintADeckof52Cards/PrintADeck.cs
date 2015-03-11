using System;

namespace _04.PrintADeckof52Cards
{
    class PrintADeck
    {
        static void Main()
        {
            // Write a program that generates and prints all possible cards from a standard deck of 52 cards 
            // (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
            // The card faces should start from 2 to A. Print each card face in its four possible suits: 
            // clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement

            string[] symbArray = { "♠", "♥", "♣", "♦" };
            

            for (int i = 2; i < 15; i++)
            {
                if (i > 1 && i < 11)
                {
                    for (int j = 0; j < symbArray.Length; j++)
                    {
                        Console.Write(i + symbArray[j] + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int o = i; o < i + 1; o++)
                    {
                        switch (i)
                        {
                            case 11: Console.WriteLine("J" + symbArray[0] + " J" + symbArray[1] + " J" + symbArray[2] + " J" + symbArray[3]); break;
                            case 12: Console.WriteLine("Q" + symbArray[0] + " Q" + symbArray[1] + " Q" + symbArray[2] + " Q" + symbArray[3]); break;
                            case 13: Console.WriteLine("K" + symbArray[0] + " K" + symbArray[1] + " K" + symbArray[2] + " K" + symbArray[3]); break;
                            case 14: Console.WriteLine("A" + symbArray[0] + " A" + symbArray[1] + " A" + symbArray[2] + " A" + symbArray[3]); break;
                        }
                    }
                }
                
                
            }
        }
    }
}

