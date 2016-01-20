namespace _08.Linq_to_Xml_Old_Albums
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class OldAlbums
    {
        static void Main()
        {
            XDocument doc = XDocument.Load("../../../catalog.xml");

            var albums =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) < 2010
                select new
                {
                    Title = album.Element("name").Value,
                    Price = album.Element("price").Value
                };

            foreach (var album in albums)
            {
                Console.WriteLine($"Album Title: {album.Title}, Price: {album.Price}");
            }
        }
    }
}
