using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ssig.Filters;
using Ssig.Models.Repositories;

namespace Ssig.Controllers.api {
  public class ArchivedMeetingsController : ApiController {
    private MeetingRepository repo = new MeetingRepository();

    // GET api/meetings
    public HttpResponseMessage Get() {
      var meetings = repo.GetAllArchivedMeetings();
      if (meetings == null) {
        return Request.CreateResponse(HttpStatusCode.NotFound);
      }
      return Request.CreateResponse(HttpStatusCode.OK, meetings);
    }

    // GET api/meeting/5
    public HttpResponseMessage Get(int page) {
      int size = 3;
      var meetings = repo.GetArchivedMeetings(page, size);
      if (meetings == null) {
        return Request.CreateResponse(HttpStatusCode.NotFound);
      }
      return Request.CreateResponse(HttpStatusCode.OK, meetings);
    }

    // POST api/meetings
    [ModelState]
    public HttpResponseMessage Post([FromBody]string value) {
      var response = Request.CreateResponse(HttpStatusCode.MethodNotAllowed);
      return response;
    }

    // PUT api/meetings/5
    [ModelState]
    public HttpResponseMessage Put(int id, [FromBody]string value) {
      var response = Request.CreateResponse(HttpStatusCode.MethodNotAllowed);
      return response;
    }

    // DELETE api/meetings/5
    public HttpResponseMessage Delete(int id) {
      var response = Request.CreateResponse(HttpStatusCode.MethodNotAllowed);
      return response;
    }
  }
}
