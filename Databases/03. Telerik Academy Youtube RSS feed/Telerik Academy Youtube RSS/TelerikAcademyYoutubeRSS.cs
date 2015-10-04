namespace Telerik_Academy_Youtube_RSS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Xml;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TelerikAcademyYoutubeRSS
    {
        private const string RssFeedUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        private const string RssFeedFilePath = "../../rss.txt";
        private const string HtmlPagePath = "../../index.html";

        public static void Main()
        {
            Console.WriteLine("Loading...");

            DowanloadContentFromUrl(RssFeedUrl, RssFeedFilePath);

            var fileContent = Utility.GetFileTextContent(RssFeedFilePath);
            var xmlDoc = ConvertStringToXml(fileContent);
            var json = ConvertXmlToJson(xmlDoc);

            var videoTitle = SelectAllTitle(json);
            PrintAllTitle(videoTitle);

            var pocoObject = ConvertJsonToPoco(json);

            CreateHtmlPage(pocoObject);
        }

        private static void CreateHtmlPage(IEnumerable<Video> pocoObject)
        {
            var htmlGenerator = new HtmlPageGenerator();
            htmlGenerator.CreateHtmlPage(HtmlPagePath, pocoObject);

            Console.WriteLine("\n-> Html page was created successfully...\n");
        }

        private static IEnumerable<Video> ConvertJsonToPoco(string json)
        {
            Console.WriteLine("\n------------------- JSON to POCO Objects: -------------------\n");

            var jsonObj = JObject.Parse(json);
            var videoEntry = jsonObj["feed"]["entry"];

            var video = videoEntry
                .Select(v => JsonConvert.DeserializeObject<Video>(v.ToString()));
            int count = 0;
            foreach (var item in video)
            {
                count++;
                Console.WriteLine(">{3}.\nTitle: {0}\nId:{1}\nLink:{2}\n", item.Title, item.Id, item.Link.Href, count);
            }

            return video;
        }

        private static IEnumerable<object> SelectAllTitle(string json)
        {
            var jsonObj = JObject.Parse(json);
            var title = jsonObj["feed"]["entry"]
                .Select(x => x["title"]);

            return title;
        }

        private static string ConvertXmlToJson(XmlDocument xmlDoc)
        {
            var jsonObj = JsonConvert.SerializeXmlNode(xmlDoc, Newtonsoft.Json.Formatting.Indented);
            return jsonObj;
        }

        private static XmlDocument ConvertStringToXml(string text)
        {
            var doc = new XmlDocument();
            doc.LoadXml(text);
            return doc;
        }

        private static void DowanloadContentFromUrl(string url, string fileName)
        {
            using (var webClient = new WebClient())
            {
                webClient.DownloadFile(url, fileName);
            }

            Console.WriteLine("\r-> RSS Feed File was downloaded succesfully...\n");
        }

        private static void PrintAllTitle(IEnumerable<object> titles)
        {
            foreach (var title in titles)
            {
                Console.WriteLine("- {0}", title);
            }
        }
    }
}
