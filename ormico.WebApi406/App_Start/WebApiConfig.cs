using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ormico.WebApi406
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //config.Formatters.Remove(config.Formatters.JsonFormatter);

            config.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.JsonFormatter);
            config.Formatters.XmlFormatter.UseXmlSerializer = true;


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
