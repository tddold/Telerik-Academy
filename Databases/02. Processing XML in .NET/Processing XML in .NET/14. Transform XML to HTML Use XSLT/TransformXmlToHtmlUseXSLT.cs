namespace _14.Transform_XML_to_HTML_Use_XSLT
{
    using System.Xml.Xsl;

    internal class TransformXmlToHtmlUseXSLT
    {
        private static void Main()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../catalogue.xslt");
            xslt.Transform("../../catalogue.xml", "../../catalogue.html");
        }
    }
}
