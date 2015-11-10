using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace JsonPlaseholderApi
{
    public class GenericHttpClient : IHttpCLient
    {
        public const string JsonHeader = "aplication/json";
        public const string XmlHeader = "aplication/xml";

        public async Task<string> GetHttpResponse(string api, string acceptHeader)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptHeader));

            var response = await client.GetAsync(new Uri(api));

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Error accessing the remote resource at {api}. \nReason: {response.ReasonPhrase}");
            }

            var contents = await response.Content.ReadAsStringAsync();

            return contents;
        }
    }
}
