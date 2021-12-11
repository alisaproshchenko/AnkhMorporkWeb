using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Fool
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fee { get; set; }
        [Required]
        public string WelcomingMessage { get; set; }
        [Required]
        public string KillingMessage { get; set; }
        [Required]
        public string PlayingMessage { get; set; }
    }
}