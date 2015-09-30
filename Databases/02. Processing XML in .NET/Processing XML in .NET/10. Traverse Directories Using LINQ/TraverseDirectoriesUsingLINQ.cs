namespace _10.Traverse_Directories_Using_LINQ
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    internal class TraverseDirectoriesUsingLINQ
    {
        private const string RootDirectory = "../../";
        private const string File = "../../file.xml";

        private static void Main()
        {
            CreateXmlDirectoryTree();

            Console.WriteLine("Document {0} was created.", File);
        }

        private static void CreateXmlDirectoryTree()
        {
            var rootDirectory = new DirectoryInfo(RootDirectory);
            var rootDirTree = GetDirTree(rootDirectory);
            var xmlDoc = new XDocument(rootDirTree);
            xmlDoc.Save(File);
        }

        private static XElement GetDirTree(DirectoryInfo rootDirTree)
        {
            var directory = new XElement("directories");
            var subDirectory = GetSubDirectoryTree(rootDirTree);
            directory.Add(subDirectory);
            return directory;
        }

        private static XElement GetSubDirectoryTree(DirectoryInfo rootDirectory)
        {
            var xmlDir = new XElement("dir", new XAttribute("name", rootDirectory.Name));

            foreach (var file in rootDirectory.GetFiles())
            {
                var xmlFile = new XElement("file", new XAttribute("name", file.Name));
                xmlDir.Add(xmlFile);
            }

            foreach (var dir in rootDirectory.GetDirectories())
            {
                xmlDir.Add(GetSubDirectoryTree(dir));
            }

            return xmlDir;
        }
    }
}
