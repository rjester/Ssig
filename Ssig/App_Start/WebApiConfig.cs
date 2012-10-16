using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Ssig {
  public static class WebApiConfig {
    public static void Register(HttpConfiguration config) {
      config.Routes.MapHttpRoute(
          name: "ArchivedMeetings",
          routeTemplate: "api/{controller}"
      );

      config.Routes.MapHttpRoute(
        name: "PagedArchivedMeetings",
        routeTemplate: "api/ArchivedMeetings/{page}",
        defaults: new { page = RouteParameter.Optional }
      );

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
    }
  }
}
