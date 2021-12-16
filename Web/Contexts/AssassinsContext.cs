using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Contexts
{
    public class AssassinsContext : DbContext
    {
        public DbSet<Assassin> Assassins { get; set; }

        public AssassinsContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Database=AnkhMorpork.Assassins;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assassin>().HasData(new[]
            {
                new Assassin{Id = 1, Busy = true, RewardMin = 15, RewardMax = 30,
                    WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
                    KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
                    PlayingMessage = "Okay, we will take this situation under our control"
                },
                new Assassin{Id = 2, Busy = false, RewardMin = 10, RewardMax = 20,
                    WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
                    KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
                    PlayingMessage = "Okay, we will take this situation under our control"
                },
                new Assassin{Id = 3, Busy = true, RewardMin = 7, RewardMax = 12,
                    WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
                    KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
                    PlayingMessage = "Okay, we will take this situation under our control"
                },
                new Assassin{Id = 4, Busy = false, RewardMin = 15, RewardMax = 19,
                    WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
                    KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
                    PlayingMessage = "Okay, we will take this situation under our control"
                },
                new Assassin{Id = 5, Busy = false, RewardMin = 9, RewardMax = 17,
                    WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
                    KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
                    PlayingMessage = "Okay, we will take this situation under our control"
                }
            });
        }
    }
}