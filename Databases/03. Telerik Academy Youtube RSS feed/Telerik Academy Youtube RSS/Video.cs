namespace Telerik_Academy_Youtube_RSS
{
    using Newtonsoft.Json;

    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }
    }
}