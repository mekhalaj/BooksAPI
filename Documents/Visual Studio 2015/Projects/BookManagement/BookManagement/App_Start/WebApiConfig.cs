using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using BookManagementBusinessLayer;
using BookManagementDataAccess;
using Microsoft.Practices.Unity;

namespace BookManagement
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Registering IBookBusinessLayer and IBookDataAccess to interfaces with unity and then create a UnityResolver object
            var container = new UnityContainer();
            container.RegisterType<IBookBusinessLayer, BookBusinessLayer>(new HierarchicalLifetimeManager());
            container.RegisterType<IBookDataAccess, BookDataAccess>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

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
