using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FootBallLeague.Models
{
    public class FootBallLeague
    {
        [Key]
        [Required]
        public int MatchId { get; set; }
        [Required]
        public string TeamName1 { get; set; }
        [Required]
        public string TeamName2 { get; set; }
        [Required]
        public string Status { get; set; }
        public string WinningTeam { get; set; }
        [Required]
        public int points { get; set; }
    }
}