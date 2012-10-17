﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ssig.Models;

namespace Ssig
{
  // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
  // visit http://go.microsoft.com/?LinkId=9394801

  public class WebApiApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();

      WebApiConfig.Register(GlobalConfiguration.Configuration);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      //Database.SetInitializer(new SsigContextInitializer());
      Database.SetInitializer(new MigrateDatabaseToLatestVersion<SsigContext, Configuration>());
      GlobalConfiguration.Configuration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

      var config = GlobalConfiguration.Configuration;
      var xmlFormatter = config.Formatters
        .Where(f => {
          return f.SupportedMediaTypes.Any(v => v.MediaType == "text/xml");
        })
        .FirstOrDefault();

      if (xmlFormatter != null) {
        config.Formatters.Remove(xmlFormatter);
      }
    }
  }
}