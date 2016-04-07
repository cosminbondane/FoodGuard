using FoodGuard.Util;
using Newtonsoft.Json.Serialization;
using SFP.Core.ServiceInjection;
using SFP.Data.Dapper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FoodGuard
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //remove the XML response type
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            // add a custom DateTime formatter to the serialized json results to always serialize DateTime as standard: yyyy-MM-ddTHH:mm:ss.fff
            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new CustomDateTimeConverter());

            // camelCase properties through json
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            DependencyServiceInjection.RegisterType(typeof(BaseDapperRepository<>), typeof(BaseDapperRepository<>));
        }
    }
}
