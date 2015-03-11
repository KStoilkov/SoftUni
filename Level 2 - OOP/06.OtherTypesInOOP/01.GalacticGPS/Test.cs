namespace _01.GalacticGPS
{
    using System;

    class Test
    {
        static void Main()
        {
            Location home = new Location(15.89123, 17.12354, Planet.Jupiter);
            Console.WriteLine(home);
        }
    }
}
