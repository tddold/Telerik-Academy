﻿using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using System.Web.Http.Cors;

namespace TheBigCatProject.Server
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var corsAttribute = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttribute);

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
