namespace Telerik_Academy_Youtube_RSS
{   
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class HtmlPageGenerator
    {
        private const string ItemTemplateFormat = "<li><a href=\"\"><strong>[{0}]</strong></a></li>";

        internal void CreateHtmlPage(string path, IEnumerable<IListVideo> listItems)
        {
            var html = this.CreateHtml(listItems);
            this.CreateFile(path, html);
        }

        private string CreateHtml(IEnumerable<IListVideo> listItems)
        {
            var html = new StringBuilder();
            html.AppendLine("<ul>");

            foreach (var item in listItems)
            {
                html.AppendFormat(ItemTemplateFormat, item.Title);
            }

            html.AppendLine("</ul>");
            return html.ToString();
        }

        private void CreateFile(string path, string html)
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    writer.WriteLine(html);
                }
            }
        }
    }
}