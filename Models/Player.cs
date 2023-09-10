using System.ComponentModel.DataAnnotations;

namespace nba_app.Models
{
    public class Player
    {
        [Required]
        public int PlayerID { get; set; }
        public string Status { get; set; }
        public int TeamID { get; set; }
        public int? Jersey { get; set; }
        public string Position { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public int? Height { get; set; } 
        public int? Weight { get; set; }
        public string BirthDate { get; set; }

        public string BirthCity { get; set; }
        public string BirthCountry { get; set; }

        public string BirthState { get; set; }  

        public string College { get; set; } 

        public int? Salary { get; set; }

        public int? Experience { get; set; }

        public int? FanDuelPlayerID { get; set; }

        public int? DraftKingsPlayerID { get; set; } 

        public int? NbaDotComPlayerID { get; set; }

        public string Headshot { get; set; }

    }
}
