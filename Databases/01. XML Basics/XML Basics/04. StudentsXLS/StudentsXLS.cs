namespace _04.StudentsXLS
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Xsl;

    class StudentsXLS
    {
        static void Main()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../students.xslt");
            xslt.Transform("../../students.xml", "../../students.html");

            var xsl = new XslCompiledTransform();
            xsl.Load("../../students.xsl");
            xsl.Transform("../../students.xml", "../../studentsXSL.html");
        }
    }
}
