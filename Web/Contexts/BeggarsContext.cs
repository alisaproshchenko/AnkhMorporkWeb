using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Contexts
{
    public class BeggarsContext
    {
        public static Beggar[] SeedData
        {
            get
            {
                return (new[]
                        {
                            new Beggar
                            {
                                Id = 1, Name = "Twitcher", Fee = 3,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Twitcher'. He wants 3$ from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 2, Name = "Drooler", Fee = 2,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Drooler'. He wants 2$ from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 3, Name = "Dribbler", Fee = 1,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Dribbler'. He wants 1$ from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 4, Name = "Mumbler", Fee = 1,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Mumbler'. He wants 1$ from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 5, Name = "Mutterer", Fee = 0.9m,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Mutterer'. He wants 90p from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 6, Name = "Walking-Along-Shouter", Fee = 0.8m,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Walking-Along-Shouter'. He wants 80p from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 7, Name = "Demander of a Chip", Fee = 0.6m,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Demander of a Chip'. He wants 60p from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 8, Name = "Someone Who Calls Other People Jimmy", Fee = 0.5m,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Someone Who Calls Other People Jimmy'. He wants 50p from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 9, Name = "Someone Who Needs Eightpence For A Meal", Fee = 0.08m,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Someone Who Needs Eightpence For A Meal'. He wants 8p from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 10, Name = "Someone Who Needs Tuppence For A Cup Of Tea", Fee = 0.02m,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Someone Who Needs Tuppence For A Cup Of Tea'. He wants 2p from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            },
                            new Beggar
                            {
                                Id = 11, Name = "Someone With Placards Saying \"Why lie? I need a beer\"", Fee = 0,
                                WelcomingMessage =
                                    "- Hello there! - you`re hearing from a suspicious guy 'Someone With Placards Saying \"Why lie? I need a beer\"'. He wants a bottle of beer from you.",
                                KillingMessage =
                                    "You`d better found any money for that beggar! After several hours of being chased by him, you DIED",
                                PlayingMessage = "- Oh THANK YOU Sooooooooo much my dear friend!"
                            }
                        }
                    );
            }
        }
        
    }
}