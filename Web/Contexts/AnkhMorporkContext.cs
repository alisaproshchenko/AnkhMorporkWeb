using System.Data.Entity;
using Web.Models;

namespace Web.Contexts
{
    public class AnkhMorporkContext : DbContext
    {
        public DbSet<Assassin> Assassins { get; set; }
        public DbSet<Beggar> Beggars { get; set; }
        public DbSet<ThievesGuild> ThievesGuilds { get; set; }
        public DbSet<Fool> Fools { get; set; }

        public AnkhMorporkContext() : base("DefaultConnection") { }

    }
}