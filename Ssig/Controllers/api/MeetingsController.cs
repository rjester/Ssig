using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ssig.Models.Repositories;

namespace Ssig.Controllers.api
{
    public class MeetingsController : ApiController
    {
          private MeetingRepository repo = new MeetingRepository();

      // GET api/meetings
        public HttpResponseMessage Get()
        {
            var meetings = repo.GetAll();
            if (meetings == null) {
              return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, meetings);
        }
    }
}
