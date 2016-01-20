namespace _07.DOM_Parser_and_XPath_Old_Albums
{
    using System;
    using System.Xml;

    public class OldAlbums
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            string xPathQuery = "/albums/album[year < 2010]";

            XmlNodeList oldAlbums = doc.SelectNodes(xPathQuery);

            Console.WriteLine("Albums published 5 years ago:");
            foreach (XmlNode oldAlbum in oldAlbums)
            {
                Console.WriteLine($"Album Name: {oldAlbum["name"].InnerText}, Price: {oldAlbum["price"].InnerText}");
            }
        }
    }
}
