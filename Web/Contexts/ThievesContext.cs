using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Contexts
{
    public class ThievesContext : DbContext
    {
        public DbSet<ThievesGuild> ThievesGuilds { get; set; }

        public ThievesContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Database=AnkhMorpork.Thieves;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThievesGuild>().HasData(new ThievesGuild
            {
                Id = 1,
                Fee = 10,
                Thefts = 6,
                WelcomingMessage = "Oh no! There`s a guy from the Guild of Thieves. You have to pay 10$ to them",
                KillingMessage =
                    "You definitely had to bring them those 10$..... Because the Game IS OVER for you by now",
                PlayingMessage = "- Have a nice evening!"
            });
        }
    }
}