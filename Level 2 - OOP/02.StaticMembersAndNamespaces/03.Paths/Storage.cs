namespace _03.Paths
{
    using _01.Point3d;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    static class Storage
    {
        // Creating new file in "../bin/Debug" and saving the points 
        // in the selected path.
        public static void SavePath(string fileName, Path3D pathToSave)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream(fileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(fs);

                using (sw)
                {
                    sw.WriteLine(pathToSave.PathName);
                    foreach (var point in pathToSave.Points)
                    {
                        sw.WriteLine(point);
                    }
  
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }

        }

        public static Path3D LoadPath(string fileName)
        {
            List<Point3D> points = new List<Point3D>();
            string name = "";

            try
            {
                StreamReader sr = new StreamReader(fileName);

                using (sr)
                {
                    name = sr.ReadLine();
                    String line = sr.ReadLine();

                    while (line != null)
                    {
                        double[] xyz = PointCatcher(line);
                        Point3D point = new Point3D(xyz[0], xyz[1], xyz[2]);
                        points.Add(point);
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new Path3D(name, points);
        }

        private static double[] PointCatcher(string line)
        {
            List<double> points = new List<double>();

            string[] splittedLine = Regex.Split(line, "[^0-9, ]");

            for (int i = 0; i < splittedLine.Length; i++)
            {
                if (splittedLine[i] != " " && splittedLine[i] != "" && splittedLine[i] != "  ")
                {
                    string p = splittedLine[i].Trim();
                    double point = double.Parse(p);
                    points.Add(point);
                }
            }

            return points.ToArray();
        }
    }
}
