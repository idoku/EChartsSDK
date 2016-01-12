using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace EChartsWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                 name: "DefaultApi",
                 routeTemplate: "api/{controller}/{action}/{id}",
                 defaults: new { id = RouteParameter.Optional }
             );

            //序列化                       
            //var jsonFormatter = new JsonMediaTypeFormatter();
            //jsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            //jsonFormatter.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            //jsonFormatter.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            //config.Formatters.Add(jsonFormatter);
            //config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));
        }
    }

    //public class JsonContentNegotiator : IContentNegotiator
    //{
    //    private readonly JsonMediaTypeFormatter _jsonFormatter;

    //    public JsonContentNegotiator(JsonMediaTypeFormatter formatter)
    //    {
    //        _jsonFormatter = formatter;
    //    }

    //    public ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
    //    {
    //        var result = new ContentNegotiationResult(_jsonFormatter, new MediaTypeHeaderValue("application/json"));
    //        return result;
    //    }
    //}
}
