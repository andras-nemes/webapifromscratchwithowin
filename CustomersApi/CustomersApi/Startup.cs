using CustomersApi.DependencyResolution;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Owin;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;

namespace CustomersApi
{
	public class Startup
	{
		public void Configuration(IAppBuilder appBuilder)
		{			
			IContainer container = IoC.Initialize();
			container.AssertConfigurationIsValid();
			Debug.WriteLine(container.WhatDoIHave());			
			HttpConfiguration httpConfiguration = new HttpConfiguration();
			httpConfiguration.DependencyResolver = new StructureMapWebApiDependencyResolver(container);			
			WebApiConfig.Register(httpConfiguration);
			appBuilder.UseWebApi(httpConfiguration);			
		}
	}
}