namespace _02.DistanceCalculator
{
    using _01.Point3d;
    using System;

    public static class DistanceCalculator
    {
        public static double calculateDistance(Point3D point1, Point3D point2)
        {
            double xDiff = Math.Pow(point1.X - point2.X, 2);
            double yDiff = Math.Pow(point1.Y - point2.Y, 2);
            double zDiff = Math.Pow(point1.Z - point2.Z, 2);
            return Math.Sqrt(xDiff + yDiff + zDiff);
        }
    }
}
