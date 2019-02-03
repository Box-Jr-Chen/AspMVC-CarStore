using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class MobileContext:DbContext
    {
        public MobileContext() : base("MobileDbConnection") { }
        public DbSet<Car> Cars { get; set; }
    }
}