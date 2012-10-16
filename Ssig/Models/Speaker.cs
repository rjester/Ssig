using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ssig.Models {
  public class Speaker {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Twitter { get; set; }

    public string FullName {
      get {
        return this.FirstName + " " + this.LastName;
      }
    }

    public string FullNameReverse {
      get {
        return this.LastName + ", " + this.FirstName;
      }
    }
  }
}