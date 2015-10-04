namespace Telerik_Academy_Youtube_RSS
{
    using Newtonsoft.Json;

    public class Video : IListVideo
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        public override string ToString()
        {
            return string.Format("Item: Title: {0}", this.Title);
        }
    }
}
