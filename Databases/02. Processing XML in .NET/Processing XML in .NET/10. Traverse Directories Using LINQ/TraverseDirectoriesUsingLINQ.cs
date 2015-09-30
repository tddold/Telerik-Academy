namespace _10.Traverse_Directories_Using_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;

    internal class TraverseDirectoriesUsingLINQ
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

            var file = new XDocument(File);


            TraverseRootDirectory(rootDirectory);



        }

        private static void TraverseRootDirectory(DirectoryInfo rootDirectory)
        {
            

            if (!rootDirectory.GetFiles().Any() && rootDirectory.GetDirectories().Any())
            {
                return;
            }

            var directories =
                new XElement("directories",
                    new XAttribute( "dir", rootDirectory.GetDirectories()),
                       
                        foreach (var file in rootDirectory.GetFiles())
                        {
                            new XAttribute("file", file.Name);
                        },  
                        )
                    )



                );
        }
    }
}
