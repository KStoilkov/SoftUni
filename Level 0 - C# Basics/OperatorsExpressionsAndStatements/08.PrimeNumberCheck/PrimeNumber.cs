using System;

namespace _08.PrimeNumberCheck
{
    class PrimeNumber
    {
        static void Main()
        {
            // Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 

            Console.Write("Enter positive number <= 100: ");
            int number = int.Parse(Console.ReadLine());

            bool primeNumber = false;

            if (number <= 100 && number > 0)
            {
                if (number == 1)
                {
                    primeNumber = false;
                }
                else if (number == 2 || number == 3 || number == 5 || number == 7)
                {
                    primeNumber = true;
                }
                else if ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0))
                {
                    primeNumber = true;
                }
                else
                {
                    primeNumber = false;
                }
            }
            if (number == 0)
            {
                primeNumber = false;
            }
            else
            {
                primeNumber = false;
            }
            Console.WriteLine("Prime? : " + primeNumber);
            Console.WriteLine();
        }
    }
}


