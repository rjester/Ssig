using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ssig.Models
{
  public class SsigContext : DbContext
  {
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<Speaker> Speakers { get; set; }

    public SsigContext() : base("name=DefaultConnection")
    {
      Configuration.ProxyCreationEnabled = false;
    }
  }
}