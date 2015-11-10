namespace FeedZillaApi
{
    using FeedZillaApi.Models;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Net;

    public class FeedZillaConsumer
    {
        private const string QueryString = "http://api.feedzilla.com/v1/categories/26/articles/search.json?q={0}&count={1}";

        public void GetArticles(string searchPattern, int countt, Action<Article> articleAction)
        {
            var queryString = BuildQueryString(searchPattern, countt);
            var request = WebRequest.Create(queryString);

            using (var responseStream = request.GetResponse().GetResponseStream())
            {
                using (var reader = new StreamReader(responseStream))
                {
                    var fzResult = JsonConvert.DeserializeObject<FZResult>(reader.ReadToEnd());
                    fzResult.Articles.ForEach(articleAction);
                }
            }
        }

        private static string BuildQueryString(string searchPattern, int countt)
        {
            var fullQueryString = string.Format(QueryString, searchPattern, countt);
            return fullQueryString;
        }
    }
}
