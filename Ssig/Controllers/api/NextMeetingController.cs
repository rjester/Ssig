using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SsigSandboxApi.Models.Repositories;

namespace SsigSandboxApi.Controllers.api
{
    public class NextMeetingController : ApiController
    {
          private MeetingRepository repo = new MeetingRepository();

      // GET api/meetings
        public HttpResponseMessage Get()
        {
            var meeting = repo.GetNextMeeting();
          if (meeting == null) {
            return Request.CreateResponse(HttpStatusCode.NotFound);
          }
          return Request.CreateResponse(HttpStatusCode.OK, meeting);
        
        }


    }
}
