namespace _03.Paths
{
    using _01.Point3d;
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main(string[] args)
        {
            List<Point3D> points = new List<Point3D>();
            points.Add(new Point3D(2.2, 2.3, 1.8));
            points.Add(new Point3D(3.2, 9.5, 5.8));
            points.Add(new Point3D(2.3, 4.1, 3.2));
            points.Add(new Point3D(4.2, 2.5, 6.6));
            points.Add(new Point3D(2.4, 4.6, 1.1));
            points.Add(new Point3D(5.2, 4.3, 7.8));
            points.Add(new Point3D(2.5, 7.5, 3.2));

            List<Point3D> morePoints = new List<Point3D>();
            morePoints.Add(new Point3D(5.4, 2.5, 1.8));
            morePoints.Add(new Point3D(5.2, 4.3, 7.8));
            morePoints.Add(new Point3D(2.4, 4.6, 1.1));
            morePoints.Add(new Point3D(2.3, 4.1, 3.2));

            Path3D myPath = new Path3D("My Path", points);
            Path3D yourPath = new Path3D("Your Path", morePoints);

            Storage.SavePath("MyPath", myPath);
            Storage.SavePath("YourPath", yourPath);

            Path3D loadedPath = Storage.LoadPath("YourPath");

            Console.WriteLine(myPath);
            Console.WriteLine(loadedPath);
        }
    }
}
