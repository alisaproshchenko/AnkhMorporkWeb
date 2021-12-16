using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class NPC
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string WelcomingMessage { get; set; }
        [Required]
        public string KillingMessage { get; set; }
        [Required]
        public string PlayingMessage { get; set; }
    }
}