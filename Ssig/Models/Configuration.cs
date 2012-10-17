using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace Ssig.Models {
  public class Configuration : DbMigrationsConfiguration<SsigContext> {
    public Configuration() {
      AutomaticMigrationsEnabled = true;
      AutomaticMigrationDataLossAllowed = true;
    }
  }
}