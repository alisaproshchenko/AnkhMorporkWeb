using System.Data.Entity;
using Web.Models;

namespace Web.Contexts
{
    public class FoolsContext : DbContext
    {
        public DbSet<Fool> Fools { get; set; }
        public FoolsContext() : base("DefaultConnection") { }
    }
}