namespace _11.Extract_Price_Albums
{
    using System;
    using System.Xml;

    internal class ExtractPriceAlbums
    {
        private static void Main()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalogue.xml");
            string xPathQuery = "/catalogue/album[year < 2005]";

            var itemNodes = xmlDoc.SelectNodes(xPathQuery);

            foreach (XmlNode node in itemNodes)
            {
                var yearNode = int.Parse(node.SelectSingleNode("year").InnerText.ToString());
                var nameNode = node.SelectSingleNode("name").InnerText;
                var priceNode = node.SelectSingleNode("price").InnerText;

                Console.WriteLine("Album name: {0, -15} -> price: {1, 2}", nameNode, priceNode);
            }
        }
    }
}