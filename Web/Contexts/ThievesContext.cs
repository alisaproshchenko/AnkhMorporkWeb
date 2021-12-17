using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Contexts
{
    public class ThievesContext
    {
        public static ThievesGuild[] SeedData
        {
            get
            {
                return (new[]
                {
                    new ThievesGuild
                    {
                        Id = 1,
                        Fee = 10,
                        Thefts = 6,
                        WelcomingMessage =
                            "Oh no! There`s a guy from the Guild of Thieves. You have to pay 10$ to them",
                        KillingMessage =
                            "You definitely had to bring them those 10$..... Because the Game IS OVER for you by now",
                        PlayingMessage = "- Have a nice evening!"
                    }
                });
            }
        }
    }
}