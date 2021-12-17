using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Contexts
{
    public class WebApplicationContext : DbContext
    {
        public DbSet<Assassin> Assassins { get; set; }
        public DbSet<Beggar> Beggars { get; set; }
        public DbSet<Fool> Fools { get; set; }
        public DbSet<ThievesGuild> ThievesGuilds { get; set; }
        public WebApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Database=AnkhMorporkDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assassin>().HasData(AssassinsContext.SeedData);
            modelBuilder.Entity<Beggar>().HasData(BeggarsContext.SeedData);
            modelBuilder.Entity<Fool>().HasData(FoolsContext.SeedData);
            modelBuilder.Entity<ThievesGuild>().HasData(ThievesContext.SeedData);
        }
    }
}