using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ssig.Models;
using Ssig.Models.Abstract;
using Ssig.Models.Repositories;

namespace Ssig.Controllers
{
  public class HomeController : Controller
  {
    private IMeetingRepository repo = new MeetingRepository();

    public ActionResult Index(int page = 1)
    {
      int size = 3;
      var nextMeeting = repo.GetNextMeeting();
      var totalRecords = repo.GetCount();
      var meetings = repo.GetArchivedMeetings(page, size);
      HomeViewModel vm = new HomeViewModel {
        NextMeeting = nextMeeting, 
        ArchivedMeetings = meetings,
        TotalPages = (int)Math.Ceiling((double)(totalRecords - 1) / size), 
        CurrentPage = page
      };
      return View(vm);
    }
  }
}
