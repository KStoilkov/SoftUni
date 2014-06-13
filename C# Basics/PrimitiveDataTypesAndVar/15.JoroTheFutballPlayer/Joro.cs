using System;

namespace _15.JoroTheFutballPlayer
{
    class Joro
    {
        static void Main()
        {
            string leap = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());
            double totalPlays = 0;
            totalPlays += hometownWeekends;
            totalPlays += (52 - hometownWeekends) * 2 / 3;
            totalPlays += numberOfHolidays / 2;
            if (leap == "t")
            {
                totalPlays += 3;
            }
            int total = (int)Math.Round(totalPlays);
            Console.WriteLine(total);

        }
    }
}
