namespace _09.Traverse_Directories
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;

    internal class TraverseDirectories
    {
        private const string RootDirectory = "../../";
        private const string File = "../../file.xml";

        private static void Main()
        {
            CreateXmlDirectoriesTree();
            Console.WriteLine("Document {0} was created.", File);
        }

        private static void CreateXmlDirectoriesTree()
        {
            var rootDirectory = new DirectoryInfo(RootDirectory);

            using (var writer = new XmlTextWriter(File, Encoding.GetEncoding("utf-8")))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("directories");
                TraverseRootDirectory(writer, rootDirectory);
                writer.WriteEndElement();
                writer.WriteEndDocument();

            }
        }

        private static void TraverseRootDirectory(XmlTextWriter writer, DirectoryInfo rootDirectory)
        {
            if (!rootDirectory.GetFiles().Any() && !rootDirectory.GetDirectories().Any())
            {
                return;
            }

            writer.WriteStartElement("dir");
            writer.WriteStartAttribute("name", rootDirectory.Name);

            foreach (var file in rootDirectory.GetFiles())
            {
                writer.WriteStartElement("file");
                writer.WriteStartAttribute("name", file.Name);
                writer.WriteEndElement();
            }

            foreach (var dir in rootDirectory.GetDirectories())
            {
                TraverseRootDirectory(writer, dir);
            }

            writer.WriteEndElement();
        }
    }
}
