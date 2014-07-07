using System;
using System.Globalization;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            // A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” 
            // (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or 
            // “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. 
            // Note that you may need to learn how to parse dates and times. 

            Console.Write("Enter time (h:mm tt): ");
            string inputedTime = Console.ReadLine();
            DateTime date = new DateTime();

            bool check = DateTime.TryParseExact(inputedTime, "h:mm tt", CultureInfo.InvariantCulture,DateTimeStyles.None, out date);

            DateTime after = DateTime.Parse("1:00 PM");
            DateTime before = DateTime.Parse("3:00 AM");
            if (check == true)
            {
                if (date >= after || date <= before)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
