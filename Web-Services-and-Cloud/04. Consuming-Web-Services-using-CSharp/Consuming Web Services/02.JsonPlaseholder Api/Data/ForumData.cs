namespace JsonPlaseholderApi
{
    using JsonPlaseholderApi.Data.Models;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ForumData : IForumData
    {
        private const string QueryString = "http://jsonplaceholder.typicode.com/posts";
        private IHttpCLient client;


        public ForumData(IHttpCLient client)
        {
            this.client = client;
        }

        public IEnumerable<string> GetPosts(string searchKey)
        {
            Task<string> postResponse = this.client.GetHttpResponse(QueryString, GenericHttpClient.JsonHeader);
            var posts = JsonConvert.DeserializeObject<List<Post>>(postResponse.Result);
            var filteredPots = posts
                .Where(p => p.Title.Contains(searchKey))
                .Select(p => p.Title);

            return filteredPots;
        }
    }
}
