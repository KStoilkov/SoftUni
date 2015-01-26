namespace _01.SquareRoot
{
    using System;

    class SquareRoot
    {
        static void Main()
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                double sqrt = Math.Sqrt(input);
                Console.WriteLine(sqrt);

            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid number.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
                
        }
    }
}
