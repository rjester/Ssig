using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Ssig.Models.Abstract;

namespace Ssig.Models.Repositories
{
  public class MeetingRepository : IMeetingRepository {
    private SsigContext _db { get; set; }

    public MeetingRepository() : this(new SsigContext()) {}
    
    public MeetingRepository(SsigContext db) {
      _db = db;
    }
    public Meeting Get(int id) {
      return _db.Meetings.SingleOrDefault(m => m.Id == id);
    }

    public Meeting GetNextMeeting() {
      return _db.Meetings.Include("Speakers").OrderByDescending(m => m.MeetingDate).FirstOrDefault();
    }

    public IEnumerable<Meeting> GetArchivedMeetings(int page, int size) {
      return _db.Meetings.Include("Speakers").OrderByDescending(m => m.MeetingDate).Skip(1).Skip((page - 1) * size).Take(size);
    }

    public IEnumerable<Meeting> GetAllArchivedMeetings() {
      return _db.Meetings.OrderByDescending(m => m.MeetingDate).Skip(1);
    }

    public IQueryable<Meeting> GetAll() {
      return _db.Meetings;
    }

    public Meeting Add(Meeting meeting) {
      _db.Meetings.Add(meeting);
      _db.SaveChanges();
      return meeting;
    }

    public Meeting Update(Meeting meeting) {
      _db.Entry(meeting).State = EntityState.Modified;
      _db.SaveChanges();
      return meeting;
    }

    public void Delete(int meetingId) {
      var meeting = Get(meetingId);
      _db.Meetings.Remove(meeting);
      _db.SaveChanges();
    }


    public int GetCount() {
      return _db.Meetings.Count();
    }
  }
}