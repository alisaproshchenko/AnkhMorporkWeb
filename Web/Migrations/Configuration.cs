using Web.Models;

namespace Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.Contexts.AnkhMorporkContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Web.Contexts.AnkhMorporkContext";
        }

        protected override void Seed(Web.Contexts.AnkhMorporkContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.Assassins.AddRange(new[]
            //{
            //    new Assassin{Id = 1, Busy = true, RewardMin = 15, RewardMax = 30, 
            //        WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
            //        KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
            //        PlayingMessage = "Okay, we will take this situation under our control"
            //    },
            //    new Assassin{Id = 2, Busy = false, RewardMin = 10, RewardMax = 20,
            //        WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
            //        KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
            //        PlayingMessage = "Okay, we will take this situation under our control"
            //    },
            //    new Assassin{Id = 3, Busy = true, RewardMin = 7, RewardMax = 12,
            //        WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
            //        KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
            //        PlayingMessage = "Okay, we will take this situation under our control"
            //    },
            //    new Assassin{Id = 4, Busy = false, RewardMin = 15, RewardMax = 19,
            //        WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
            //        KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
            //        PlayingMessage = "Okay, we will take this situation under our control"
            //    },
            //    new Assassin{Id = 5, Busy = false, RewardMin = 9, RewardMax = 17,
            //        WelcomingMessage = "Oh! It seems like someone wants to kill you! I think you should make a contract with The Assassins Guild to help you",
            //        KillingMessage = "Unfortunately, the Assassins` Guild didn`t help you and you WERE KILLED",
            //        PlayingMessage = "Okay, we will take this situation under our control"
            //    }
            //});
            //context.ThievesGuilds.Add(new ThievesGuild
            //{
            //    Id = 1, Fee = 10, Thefts = 6,
            //    WelcomingMessage = "Oh no! There`s a guy from the Guild of Thieves. You have to pay 10$ to them",
            //    KillingMessage =
            //        "You definitely had to bring them those 10$..... Because the Game IS OVER for you by now",
            //    PlayingMessage = "- Have a nice evening!"
            //});
        }
    }
}
