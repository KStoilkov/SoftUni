namespace _04.DOM_Parser_Extract_Artist_and_Albums
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ExtractArtistAndNumberOfAlbums
    {
        public static Dictionary<string, int> artistAlbums = new Dictionary<string, int>();

        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                string artistName = node["artist"].InnerText;

                if (artistAlbums.ContainsKey(artistName))
                {
                    artistAlbums[artistName]++;
                }
                else
                {
                    artistAlbums[artistName] = 1;
                }
            }

            foreach (KeyValuePair<string,int> artistAlbum in artistAlbums)
            {
                Console.WriteLine($"Artist: {artistAlbum.Key}, Albums: {artistAlbum.Value}");
            }
        }
    }
}
