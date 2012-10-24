using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ssig.Filters;
using Ssig.Models;
using Ssig.Models.Repositories;

namespace Ssig.Controllers.Api
{
    public class MeetingController : ApiController
    {
        // GET api/meeting
      public HttpResponseMessage Get()
        {
          MeetingRepository repo = new MeetingRepository();
          var meeting = repo.GetNextMeeting();
          if (meeting == null) {
            return Request.CreateResponse(HttpStatusCode.NotFound);
          }
          return Request.CreateResponse(HttpStatusCode.OK, meeting);
        }

        // GET api/meeting/5
        public HttpResponseMessage Get(int id) {
          MeetingRepository repo = new MeetingRepository();
          var meeting = repo.Get(id);
          if (meeting == null) {
            return Request.CreateResponse(HttpStatusCode.NotFound);
          }
          return Request.CreateResponse(HttpStatusCode.OK, meeting);
        }

        
        
        // POST api/meeting
    [ModelState]
        public HttpResponseMessage Post(Meeting meeting) {
          var response = Request.CreateResponse(HttpStatusCode.MethodNotAllowed);
          return response;
        }

        // PUT api/meeting/5
    [ModelState]
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
          var response = Request.CreateResponse(HttpStatusCode.MethodNotAllowed);
          return response;
        }

        // DELETE api/meeting/5
        public HttpResponseMessage Delete(int id)
        {
          var response = Request.CreateResponse(HttpStatusCode.MethodNotAllowed);
          return response;
        }
    }
}
