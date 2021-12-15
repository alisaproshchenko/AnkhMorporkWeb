using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class ThievesGuild
    {
        [Key]
        public int Id { get; set; }
        public int Thefts { get; set; }
        public int Fee { get; set; }
        [Required]
        public string WelcomingMessage { get; set; }
        [Required]
        public string KillingMessage { get; set; }
        [Required]
        public string PlayingMessage { get; set; }
    }
}