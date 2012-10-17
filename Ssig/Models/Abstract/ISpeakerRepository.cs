using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ssig.Models.Abstract {
  public interface ISpeakerRepository {
    Speaker Get(int id);
    IQueryable<Speaker> GetAll();
    Speaker Add(Speaker speaker);
    Speaker Update(Speaker speaker);
    void Delete(int speakerId);
  }
}
