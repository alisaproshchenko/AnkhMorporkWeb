using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Contexts
{
    public class BeggarsContext : DbContext
    {
        public DbSet<Beggar> Beggars { get; set; }
        public BeggarsContext() : base("DefaultConnection") { }
    }
}