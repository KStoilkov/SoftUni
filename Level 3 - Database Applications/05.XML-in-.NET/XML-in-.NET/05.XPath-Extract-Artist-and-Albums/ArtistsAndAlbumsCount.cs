namespace _05.XPath_Extract_Artist_and_Albums
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class ArtistsAndAlbumsCount
    {
        public static Dictionary<string, int> artistsAlbums = new Dictionary<string, int>();

        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");
            
            string xPathQuery = "/albums/album/artist";

            XmlNodeList artists = doc.SelectNodes(xPathQuery);

            foreach (XmlNode artist in artists)
            {
                string artistName = artist.InnerText;

                if (artistsAlbums.ContainsKey(artistName))
                {
                    artistsAlbums[artistName]++;
                }
                else
                {
                    artistsAlbums[artistName] = 1;
                }
            }

            foreach (KeyValuePair<string, int> keyValuePair in artistsAlbums)
            {
                Console.WriteLine($"Artist: {keyValuePair.Key}, albums count: {keyValuePair.Value}");
            }
        }
    }
}
