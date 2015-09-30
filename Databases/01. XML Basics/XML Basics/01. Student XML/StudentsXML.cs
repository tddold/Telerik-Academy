namespace _01.Student_XML
{
    using System;
    using System.Xml.Linq;

    class StudentsXML
    {
        static void Main()
        {
            var studentsXML = XElement.Load("../../students.xml");
            Console.WriteLine(studentsXML);
        }
    }
}
