using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Contexts
{
    public class ThievesContext : DbContext
    {
        public DbSet<ThievesGuild> ThievesGuilds { get; set; }
        public ThievesContext() : base("DefaultConnection") { }
    }
}