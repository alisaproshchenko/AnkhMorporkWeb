using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Contexts
{
    public class FoolsContext : DbContext
    {
        public DbSet<Fool> Fools { get; set; }
        public FoolsContext() : base("DefaultConnection") { }
    }
}