namespace _02.Parse_XML
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    class ParseXML
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../catalogue.xml");

            var rootNode = doc.DocumentElement;
            var artists = new Dictionary<string, int>();

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var artistName = node["artist"].InnerText;

                if (!artists.ContainsKey(artistName))
                {
                    artists[artistName] = 0;
                }

                artists[artistName]++;
            }

            foreach (var item in artists)
            {
                Console.WriteLine("Artist Name:{0,-25}Number of Albums {1,10}", item.Key, item.Value);
            }
        }
    }
}
