using System;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            // The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates 
            // the weight of a man on the moon by a given weight on the Earth. 

            Console.Write("Your weight: ");
            double weight = double.Parse(Console.ReadLine());
            weight = weight * (17.0 / 100.0);
            Console.WriteLine("Your weight on the moon: {0:F2}",weight);
        }
    }
}
