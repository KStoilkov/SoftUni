namespace _03.DOM_Parser_Extract_All_Artists
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ExtractAllArtists
    {
        public static SortedSet<string> artists = new SortedSet<string>();

        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                artists.Add(node["artist"].InnerText);
            }

            foreach (var artist in artists)
            {
                Console.WriteLine(artist);
            }
        }
    }
}
