namespace _02.DistanceCalculator
{
    using _01.Point3d;
    using System;

    class Test
    {
        static void Main(string[] args)
        {
             Point3D point1 = new Point3D(2.3, 1.5, 5.3);
             Point3D point2 = new Point3D(5.3, 4.2, 2.8);
             Console.WriteLine(DistanceCalculator.calculateDistance(point1, point2).ToString("F"));
        }
    }
}
