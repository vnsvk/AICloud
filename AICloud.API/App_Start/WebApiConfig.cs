﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AICloud.API
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
						config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
						config.Formatters.JsonFormatter.SupportedMediaTypes.Add(
								new System.Net.Http.Headers.MediaTypeHeaderValue("application/json-patch+json"));
				}
		}
}
