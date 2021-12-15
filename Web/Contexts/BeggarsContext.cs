using System.Data.Entity;
using Web.Models;

namespace Web.Contexts
{
    public class BeggarsContext : DbContext
    {
        public DbSet<Beggar> Beggars { get; set; }
        public BeggarsContext() : base("DefaultConnection") { }
    }
}