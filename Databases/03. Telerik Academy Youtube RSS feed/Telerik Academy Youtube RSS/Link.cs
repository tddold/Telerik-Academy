namespace Telerik_Academy_Youtube_RSS
{
    using Newtonsoft.Json;

    public class Link 
    {
        [JsonProperty("@href")]
        public string Href { get; set; }

        [JsonProperty("@rel")]
        public string Rel { get; set; }
    }
}
