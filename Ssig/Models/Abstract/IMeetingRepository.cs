using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ssig.Models.Abstract {
  public interface IMeetingRepository {
    Meeting Get(int id);
    Meeting GetNextMeeting();
    IEnumerable<Meeting> GetArchivedMeetings(int page, int size);
    IEnumerable<Meeting> GetAllArchivedMeetings();
    IQueryable<Meeting> GetAll();
    Meeting Add(Meeting meeting);
    Meeting Update(Meeting meeting);
    void Delete(int MeetingId);
    int GetCount();
  }
}
