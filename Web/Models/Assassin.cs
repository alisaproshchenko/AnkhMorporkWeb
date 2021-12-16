using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Assassin : NPC
    {
        public bool Busy { get; set; }
        public decimal RewardMin { get; set; }
        public decimal RewardMax { get; set; }

    }
}