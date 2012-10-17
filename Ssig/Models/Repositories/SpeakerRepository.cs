using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Ssig.Models.Abstract;

namespace Ssig.Models.Repositories
{
  public class SpeakerRepository : ISpeakerRepository {
    private SsigContext _db { get; set; }

    public SpeakerRepository() : this(new SsigContext()) {}
    
    public SpeakerRepository(SsigContext db) {
      _db = db;
    }
    public Speaker Get(int id) {
      return _db.Speakers.SingleOrDefault(m => m.Id == id);
    }

    public IQueryable<Speaker> GetAll() {
      return _db.Speakers;
    }

    public Speaker Add(Speaker speaker) {
      _db.Speakers.Add(speaker);
      _db.SaveChanges();
      return speaker;
    }

    public Speaker Update(Speaker speaker) {
      _db.Entry(speaker).State = EntityState.Modified;
      _db.SaveChanges();
      return speaker;
    }

    public void Delete(int speakerId) {
      var speaker = Get(speakerId);
      _db.Speakers.Remove(speaker);
      _db.SaveChanges();
    }
  }
}