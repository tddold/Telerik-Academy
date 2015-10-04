namespace Telerik_Academy_Youtube_RSS
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class HtmlPageGenerator
    {
        private const string ItemTemplateFormat = "<div style=\"float:left; width: 420px; height: 450px; padding:10px;" +
                                  "margin:5px; background-color:green; border-radius:10px\">" +
                                  "<iframe width=\"420\" height=\"345\" " +
                                  "src=\"http://www.youtube.com/embed/{1}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                   "<h3>{2}</h3>" +
                                   "<a href=\"{0}\">Go to YouTube</a></div>";

        internal void CreateHtmlPage(string path, IEnumerable<Video> videos)
        {
            var html = this.CreateHtml(videos);
            this.CreateFile(path, html);
        }

        private string CreateHtml(IEnumerable<Video> videos)
        {
            var html = new StringBuilder();

            html.AppendLine("<!DOCOTYPE html><html><body><h1>Processing-JSON-in-.NET</h1>");

            foreach (var item in videos)
            {
                html.AppendFormat(ItemTemplateFormat, item.Link.Href, item.Id, item.Title);
            }

            html.AppendLine("<body><html>");
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