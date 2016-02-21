namespace Battleships.ConsoleApplication
{
    using System;

    public class BattleshipsMain
    {
        public static void Main()
        {
            Console.WriteLine("Battleships game.");
            string input = Console.ReadLine();

            while (input != "exit")
            {
                Engine.ParseCommand(input);
                input = Console.ReadLine();
            }
        }
    }
}
