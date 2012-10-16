using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ssig.Models {
  public class SsigContextInitializer : DropCreateDatabaseIfModelChanges<SsigContext> {
    protected override void Seed(SsigContext context) {
      context.Meetings.Add(
        new Meeting {
          Id = 1,
          Title = "Meeting 1",
          Description = "Description",
          MeetingDate = new DateTime(2012, 1, 1)
        }
       );

      context.Meetings.Add(
        new Meeting {
          Id = 2,
          Title = "Meeting 2",
          Description = "Description1",
          MeetingDate = new DateTime(2012, 2, 1)
        }
       );

      context.SaveChanges();
    }
  }
}