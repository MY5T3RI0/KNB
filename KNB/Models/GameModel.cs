using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KNB.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        [Required]
        public string PlayerChoice { get; set; }
        public string OpponentChoice { get; set; }
        public string GameResult { get; set; }
    }
}