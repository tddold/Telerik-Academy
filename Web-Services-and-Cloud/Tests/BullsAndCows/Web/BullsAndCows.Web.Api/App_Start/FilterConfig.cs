﻿using System.Web;
using System.Web.Mvc;

namespace BullsAndCows.Web.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
