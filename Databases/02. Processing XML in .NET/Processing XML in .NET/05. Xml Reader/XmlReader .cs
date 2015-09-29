namespace _05.Xml_Reader
{
    using System;
    using System.Xml;

    class Program
    {
        static void Main()
        {
            string file = "../../catalogue.xml";

            using (XmlReader reader = XmlReader.Create(file))
            {
                int count = 1;
                Console.WriteLine("Name of songs is:");

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        var song = reader.ReadElementContentAsString();
                        Console.WriteLine("{0, 2}. {1}", count, song);
                        count++;
                    }
                }
            }
        }
    }
}
