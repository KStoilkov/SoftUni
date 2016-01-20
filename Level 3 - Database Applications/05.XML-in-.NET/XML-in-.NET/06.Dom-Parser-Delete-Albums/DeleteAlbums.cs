using System.Xml;

namespace _06.Dom_Parser_Delete_Albums
{
    public class DeleteAlbums
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                decimal price = decimal.Parse(node["price"].InnerText);

                if (price > 20)
                {
                    rootNode.RemoveChild(node);
                }
            }

            doc.Save("../../../cheap-albums-catalog.xml");
        }
    }
}
