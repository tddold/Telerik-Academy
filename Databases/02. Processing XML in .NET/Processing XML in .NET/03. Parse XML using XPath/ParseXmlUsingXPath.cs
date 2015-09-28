namespace _03.Parse_XML_using_XPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class ParseXmlUsingXPath
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../catalogue.xml");

            var artistDictionary = new Dictionary<string, int>();

            string xPathQuery = "/catalogue/album";
            var artists = doc.SelectNodes(xPathQuery);

            foreach (XmlNode artist in artists)
            {
                string artistName = artist.SelectSingleNode("artist").InnerText;

                if (!artistDictionary.ContainsKey(artistName))
                {
                    artistDictionary[artistName] = 0;
                }

                artistDictionary[artistName]++;
            }

            foreach (var item in artistDictionary)
            {
                Console.WriteLine("Artist Name:{0,-25}Number of Albums {1,10}", item.Key, item.Value);
            }
        }
    }
}
