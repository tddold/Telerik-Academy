namespace _04.Remove_XML_Element
{
    using System;
    using System.Xml;

    class RemoveXmlElement
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../catalogue.xml");

            string xPathQuery = "/catalogue/album";

            var nodeList = doc.SelectNodes(xPathQuery);

            foreach (XmlNode node in nodeList)
            {
                if (decimal.Parse(node["price"].InnerText) > 20)
                {
                    var artistName = node["artist"].InnerText;
                    var price = node["price"].InnerText;
                    Console.WriteLine("Artist name: {0} with price for his album is great than 20, will be removed", artistName);

                    node.ParentNode.RemoveChild(node);
                }
            }

            doc.Save("../../catalogueNew.xml");
            Console.WriteLine("New catalogue are saved in file: catalogueNew.xml!");
        }
    }
}
