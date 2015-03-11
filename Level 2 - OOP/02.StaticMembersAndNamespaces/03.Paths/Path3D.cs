namespace _03.Paths
{
    using _01.Point3d;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    
    class Path3D
    {
        private string pathName;
        private List<Point3D> points;

        public Path3D(string pathName, List<Point3D> points)
        {
            this.PathName = pathName;
            this.Points = points;
        }

        public string PathName 
        {
            get
            {
                return this.pathName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Path name cannot be null or empty.");
                }
                this.pathName = value;
            }
        }

        public List<Point3D> Points 
        {
            get
            {
                return this.points;
            }
            private set
            {
                this.points = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Name: " + this.PathName);
            int counter = 0;

            foreach (var point in this.points)
            {
                result.AppendLine(string.Format("Point {0} ( {1}, {2}, {3} )", counter, point.X, point.Y, point.Z));
                counter++;
            }

            return result.ToString();
        }
    }
}
