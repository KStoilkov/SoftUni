using System;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            bool isValid = false;
            int tester = 0;

            for (int i = 1; i < 11; i++)
            {
                while (!isValid)
                {
                    try
                    {
                        Console.Write(i + ": ");
                        int input = ReadNumber(1, 100);

                        if (input != -1)
                        {
                            if (input <= tester)
                            {
                                throw new ArgumentOutOfRangeException();
                            }
                            tester = input;
                            isValid = true;
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        isValid = false;
                        Console.WriteLine("Number must be bigger than previous. Try Again: ");
                    }
                }

                isValid = false;
            }
            Console.WriteLine("Succeed!");
        }

        public static int ReadNumber(int start, int end)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!. Try Again: ");
                return -1;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number must be between [1..100]. Try Again: ");
                return -1;
            }
        }
    }
}
