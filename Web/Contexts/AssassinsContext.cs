using System.Data.Entity;
using Web.Models;

namespace Web.Contexts
{
    public class AssassinsContext : DbContext
    {
        public DbSet<Assassin> Assassins { get; set; }
        public AssassinsContext() : base("DefaultConnection") { }
    }
}