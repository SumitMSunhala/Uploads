using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GlobalHRMSApi
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
            // Web API configuration and services
            //EnableCrossSiteRequests(config);
            // Web API routes
            var enableCorsAttribute = new EnableCorsAttribute("*",
                                               "Origin, Content-Type, Accept",
                                               "GET, POST");
            config.EnableCors(enableCorsAttribute);


            config.MapHttpAttributeRoutes();
			config.MessageHandlers.Add(new TokenValidationHandler());
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}

        //private static void EnableCrossSiteRequests(HttpConfiguration config)
        //{
        //    var cors = new EnableCorsAttribute(
        //        origins: "http://globalhrms.in",
        //        headers: "*",
        //        methods: "*");
        //    config.EnableCors(cors);
        //}

    }
}
