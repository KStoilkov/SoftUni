namespace _01.Point3d
{
    using System;

    class Test
    {
        static void Main(string[] args)
        {
            Point3D point1 = new Point3D(5.2, 8.1, 2.7);
            Console.WriteLine(point1);
            point1 = Point3D.ReturnToStartingPoint();
            Console.WriteLine(point1);
        }
    }
}
