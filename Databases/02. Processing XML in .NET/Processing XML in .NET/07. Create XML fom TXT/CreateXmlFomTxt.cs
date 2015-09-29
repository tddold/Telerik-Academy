namespace _07.Create_XML_fom_TXT
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml.Linq;


    class CreateXmlFomTxt
    {
        static void Main()
        {
            string file = "../../persons.txt";

            Console.WriteLine("Reading persons.txt file using StreamReader");
            var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
            var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128);

            XElement personsXml = new XElement("persons");

            string name = string.Empty;
            string address = string.Empty;

            using (streamReader)
            {
                string line = string.Empty;
                int count = 1;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (count % 3 == 1)
                    {
                        name = line;
                    }
                    else if (count % 3 == 2)
                    {
                        address = line;
                    }
                    else
                    {
                        var phone = line;

                        personsXml.Add(new XElement("person",
                            new XElement("name", name),
                            new XElement("address", address),
                            new XElement("phone", phone)));
                    }

                    count++;
                }

            }

            Console.WriteLine(personsXml);
            personsXml.Save("../../persons.xml");
            Console.WriteLine("File created");
        }
    }
}
