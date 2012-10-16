using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ssig.Models
{
  public class Meeting
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime MeetingDate { get; set; }
    public string Description { get; set; }
    //public IList<Presentation> Presentations { get; set; }
    public string[] Tags { get; set; }
    //public IList<Resource> Resources { get; set; }
    public IList<Speaker> Speakers { get; set; }
  }
}