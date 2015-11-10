namespace JsonPlaseholderApi
{
    using System.Threading.Tasks;

    public interface IHttpCLient
    {
        Task<string> GetHttpResponse(string api, string acceptHeader);
    }
}
