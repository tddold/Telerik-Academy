namespace _08.Create_Album_XML
{
    using System;
    using System.Text;
    using System.Xml;

    public class CreateAlbumXML
    {
        private const string File = "../../catalogue.xml";
        private const string NewFile = "../../album.xml";

        public static void Main()
        {
            GenerateAlbumXML();
        }

        private static void GenerateAlbumXML()
        {
            XmlTextWriter writer = new XmlTextWriter(NewFile, Encoding.GetEncoding("utf-8"));
            using (writer)
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartElement("albums");

                string name = string.Empty;

                using (XmlReader reader = XmlReader.Create(File))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                        {
                            name = reader.ReadElementContentAsString();
                        }
                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "artist")
                        {
                            string artist = reader.ReadElementContentAsString();
                            WriteAlbum(writer, name, artist);
                        }
                    }
                }

                writer.WriteEndDocument();
                Console.WriteLine("Document {0} was created.", NewFile);
            }
        }

        private static void WriteAlbum(XmlTextWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }
    }
}
