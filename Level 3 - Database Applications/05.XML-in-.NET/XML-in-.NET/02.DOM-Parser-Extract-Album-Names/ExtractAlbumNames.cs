namespace _02.DOM_Parser_Extract_Album_Names
{
    using System;
    using System.Xml;

    public class ExtractAlbumNames
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                Console.WriteLine($"Album Name: {node["name"].InnerText}");
            }
        }
    }
}
