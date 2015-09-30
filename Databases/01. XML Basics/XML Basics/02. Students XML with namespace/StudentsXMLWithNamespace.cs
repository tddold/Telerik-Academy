namespace _02.Students_XML_with_namespace
{
    using System;
    using System.Xml.Linq;

    class StudentsXmlWithNamespace
    {
        static void Main()
        {
            var studentsXML = XElement.Load("../../students.xml");
            Console.WriteLine(studentsXML);
        }
    }
}
