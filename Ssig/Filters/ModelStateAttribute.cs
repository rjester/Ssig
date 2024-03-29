﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Ssig.Filters {
  public class ModelStateAttribute : ActionFilterAttribute {
    public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext) {
      if (!actionContext.ModelState.IsValid) {
        actionContext.Response =  actionContext.Request.CreateErrorResponse(
              HttpStatusCode.BadRequest, actionContext.ModelState);
      }
    }
  }
}