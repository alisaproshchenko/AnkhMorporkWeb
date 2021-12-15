using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Contexts
{
    public class AssassinsContext : DbContext
    {
        public DbSet<Assassin> Assassins { get; set; }
        public AssassinsContext() : base("DefaultConnection") { }
    }
}