using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Contexts
{
    public class FoolsContext : DbContext
    {
        public DbSet<Fool> Fools { get; set; }

        public FoolsContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Database=AnkhMorporkDB.Fools;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fool>().HasData(new[]
            {
                new Fool {
                    Id = 1, Name = "Muggin", Fee = 0.5m,
                    WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
                                       "What about trying yourself as a 'Muggin' and earn 50p?",
                    KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
                    PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
                },
                new Fool {
                    Id = 2, Name = "Gull", Fee = 1,
                    WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
                                       "What about trying yourself as a 'Gull' and earn 1$?",
                    KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
                    PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
                },
                new Fool {
                    Id = 3, Name = "Dupe", Fee = 2,
                    WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
                                       "What about trying yourself as a 'Dupe' and earn 2$?",
                    KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
                    PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
                },
                new Fool {
                    Id = 4, Name = "Butt", Fee = 3,
                    WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
                                       "What about trying yourself as a 'Butt' and earn 3$?",
                    KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
                    PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
                },
                new Fool {
                    Id = 5, Name = "Fool", Fee = 5,
                    WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
                                       "What about trying yourself as a 'Fool' and earn 5$?",
                    KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
                    PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
                },
                new Fool {
                    Id = 6, Name = "Tomfool", Fee = 6,
                    WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
                                       "What about trying yourself as a 'Tomfool' and earn 6$?",
                    KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
                    PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
                },
                new Fool {
                    Id = 7, Name = "Stupid Fool", Fee = 7,
                    WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
                                       "What about trying yourself as a 'Stupid Fool' and earn 7$?",
                    KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
                    PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
                },
                new Fool {
                    Id = 8, Name = "Arch Fool", Fee = 8,
                    WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
                                       "What about trying yourself as a 'Arch Fool' and earn 8$?",
                    KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
                    PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
                },
                new Fool {
                    Id = 9, Name = "Complete Fool", Fee = 10,
                    WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
                                       "What about trying yourself as a 'Complete Fool' and earn 10$?",
                    KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
                    PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
                }
            });
        }
    }
}