using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Assassin
    {
        [Key]
        public int Id { get; set; }
        public bool Busy { get; set; }
        public int RewardMin { get; set; }
        public int RewardMax { get; set; }
        [Required]
        public string WelcomingMessage { get; set; }
        [Required]
        public string KillingMessage { get; set; }
        [Required]
        public string PlayingMessage { get; set; }
    }
}