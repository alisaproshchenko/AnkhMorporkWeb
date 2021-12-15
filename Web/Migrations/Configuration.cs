using Web.Models;

namespace Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.Contexts.AssassinsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Web.Contexts.AssassinsContext";
        }

        protected override void Seed(Web.Contexts.AssassinsContext context)
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
            //context.Beggars.AddRange(new[]
            //{
            //    new Beggar{Id = 1, Name = "Twitcher", Fee = 3, 
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Twitcher'. He wants 3$ from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 2, Name = "Drooler", Fee = 2,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Drooler'. He wants 2$ from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 3, Name = "Dribbler", Fee = 1,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Dribbler'. He wants 1$ from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 4, Name = "Mumbler", Fee = 1,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Mumbler'. He wants 1$ from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 5, Name = "Mutterer", Fee = 0.9,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Mutterer'. He wants 90p from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 6, Name = "Walking-Along-Shouter", Fee = 0.8,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Walking-Along-Shouter'. He wants 80p from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 7, Name = "Demander of a Chip", Fee = 0.6,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Demander of a Chip'. He wants 60p from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 8, Name = "Someone Who Calls Other People Jimmy", Fee = 0.5,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Someone Who Calls Other People Jimmy'. He wants 50p from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 9, Name = "Someone Who Needs Eightpence For A Meal", Fee = 0.08,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Someone Who Needs Eightpence For A Meal'. He wants 8p from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 10, Name = "Someone Who Needs Tuppence For A Cup Of Tea", Fee = 0.02,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Someone Who Needs Tuppence For A Cup Of Tea'. He wants 2p from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    },
            //    new Beggar{Id = 11, Name = "Someone With Placards Saying \"Why lie? I need a beer\"", Fee = 0,
            //        WelcomingMessage = "- Hello there! - you`re hearing from a suspicious guy 'Someone With Placards Saying \"Why lie? I need a beer\"'. He wants a bottle of beer from you.",
            //        KillingMessage = "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
            //        PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
            //    }
            //});
            //context.Fools.AddRange(new[]
            //{
            //    new Fool {
            //        Id = 1, Name = "Muggin", Fee = 0.5,
            //        WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
            //                           "What about trying yourself as a 'Muggin' and earn 50p?",
            //        KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
            //        PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
            //    },
            //    new Fool {
            //        Id = 2, Name = "Gull", Fee = 1,
            //        WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
            //                           "What about trying yourself as a 'Gull' and earn 1$?",
            //        KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
            //        PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
            //    },
            //    new Fool {
            //        Id = 3, Name = "Dupe", Fee = 2,
            //        WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
            //                           "What about trying yourself as a 'Dupe' and earn 2$?",
            //        KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
            //        PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
            //    },
            //    new Fool {
            //        Id = 4, Name = "Butt", Fee = 3,
            //        WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
            //                           "What about trying yourself as a 'Butt' and earn 3$?",
            //        KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
            //        PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
            //    },
            //    new Fool {
            //        Id = 5, Name = "Fool", Fee = 5,
            //        WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
            //                           "What about trying yourself as a 'Fool' and earn 5$?",
            //        KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
            //        PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
            //    },
            //    new Fool {
            //        Id = 6, Name = "Tomfool", Fee = 6,
            //        WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
            //                           "What about trying yourself as a 'Tomfool' and earn 6$?",
            //        KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
            //        PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
            //    },
            //    new Fool {
            //        Id = 7, Name = "Stupid Fool", Fee = 7,
            //        WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
            //                           "What about trying yourself as a 'Stupid Fool' and earn 7$?",
            //        KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
            //        PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
            //    },
            //    new Fool {
            //        Id = 8, Name = "Arch Fool", Fee = 8,
            //        WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
            //                           "What about trying yourself as a 'Arch Fool' and earn 8$?",
            //        KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
            //        PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
            //    },
            //    new Fool {
            //        Id = 9, Name = "Complete Fool", Fee = 10,
            //        WelcomingMessage = "What`s the fortune! You met up with an old friend, who is ready to propose a some kind of job. " +
            //                           "What about trying yourself as a 'Complete Fool' and earn 10$?",
            //        KillingMessage = "- Okay, as you wish.... Hope we`ll meet later more!",
            //        PlayingMessage = "- That`s a really nice idea, moreover, these money will be useful for you!"
            //    }
            //});
        }
    }
}
