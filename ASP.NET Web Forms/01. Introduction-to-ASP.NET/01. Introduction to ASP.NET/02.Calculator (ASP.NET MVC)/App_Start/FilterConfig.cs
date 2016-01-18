using System.Web;
using System.Web.Mvc;

namespace _02.Calculator__ASP.NET_MVC_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
