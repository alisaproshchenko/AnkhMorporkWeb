using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class ThievesGuild : NPC
    {
        public int Thefts { get; set; }
        public decimal Fee { get; set; }
    }
}