using System.Data.Entity;
using Web.Models;

namespace Web.Contexts
{
    public class ThievesContext : DbContext
    {
        public DbSet<ThievesGuild> ThievesGuilds { get; set; }
        public ThievesContext() : base("DefaultConnection") { }
    }
}