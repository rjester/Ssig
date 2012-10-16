using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ssig.Models {
  public class HomeViewModel {
    public Meeting NextMeeting { get; set; }
    public IEnumerable<Meeting> ArchivedMeetings { get; set; }
    public int TotalPages { get; set; }
    public int CurrentPage { get; set; }
  }
}