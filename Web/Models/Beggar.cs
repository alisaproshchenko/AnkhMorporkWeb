using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Beggar :NPC
    {
        public string Name { get; set; }
        public decimal Fee { get; set; }
    }
}