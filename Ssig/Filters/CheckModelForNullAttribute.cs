﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Net.Http;
using System.Net;

namespace Ssig.Filters {
  [AttributeUsage(AttributeTargets.Method, Inherited = true)]
  public class CheckModelForNullAttribute : ActionFilterAttribute {
    private readonly Func<Dictionary<string, object>, bool> _validate;

    public CheckModelForNullAttribute() : this(arguments => arguments.ContainsValue(null)) { }

    public CheckModelForNullAttribute(Func<Dictionary<string, object>, bool> checkCondition) {
      _validate = checkCondition;
    }

    public override void OnActionExecuting(System.Web.Http.Controllers.HttpActionContext actionContext) {
      if (_validate(actionContext.ActionArguments)) 
        actionContext.Response = actionContext.Request.CreateErrorResponse(
          HttpStatusCode.BadRequest, "The argument cannot be null");
      
    }

  }
}