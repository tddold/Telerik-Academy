using System.Web;
using System.Web.Mvc;

namespace ASP.NET_SOAP_To_RESTful_Converter1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
