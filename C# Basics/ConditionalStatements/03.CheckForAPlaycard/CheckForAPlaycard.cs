using System;

namespace _03.CheckForAPlaycard
{
    class CheckForAPlaycard
    {
        static void Main()
        {
            // Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
            // Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

            string chosenCard = Console.ReadLine();

            if (chosenCard == "J" || chosenCard == "Q" || chosenCard == "K" || chosenCard == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                int numCard;
                numCard = int.Parse(chosenCard);
                if (numCard >= 2 && numCard <= 10)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            
        }
    }
}
