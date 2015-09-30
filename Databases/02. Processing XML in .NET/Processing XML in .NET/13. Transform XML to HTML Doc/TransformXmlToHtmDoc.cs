namespace _13.Transform_XML_to_HTML_Doc
{
   
    using System.Xml.Xsl;

    class TransformXmlToHtmDoc
    {
        static void Main()
        {
            var xsl = new XslCompiledTransform();
            xsl.Load("../../catalogue.xsl");
            xsl.Transform("../../catalogue.xml", "../../catalogue.html");
        }
    }
}
