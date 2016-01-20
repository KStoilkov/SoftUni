namespace _09.XmlWriter_DirectoryContentsAsXml
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class DirectoryContentsAsXml
    {
        static void Main()
        {
            string path = "C:\\Program Files\\Adobe";

            var element = new XElement("root-dir", new XAttribute("path", path));
            
            DirSearch(path, element);

            element.Save("../../../dirAsXml.xml");
            Console.WriteLine("You can find the .xml file in the solution folder.");
        }

        public static void DirSearch(string sDir, XElement rootDir)
        {
            try
            {
                var directories = Directory.GetDirectories(sDir);
                foreach (string dir in directories)
                {
                    var nextDir = new XElement("dir", new XAttribute("name", Path.GetFileName(dir)));
                    rootDir.Add(nextDir);

                    DirSearch(dir, nextDir);

                    var files = Directory.GetFiles(dir);
                    foreach (string file in files)
                    {
                        nextDir.Add(new XElement("file", new XAttribute("name", Path.GetFileName(file))));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
