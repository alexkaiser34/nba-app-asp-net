using System.ComponentModel.DataAnnotations;

namespace nba_app.Models
{
    public interface StandingsConference
    {
        [Required]
        public string name { get; set; }
        public int? rank { get; set; }  
        public int? win { get;   set; }
        public int? loss { get; set; }

    }

    public interface StandingsDivision : StandingsConference
    {
        public string gamesBehind { get; set; }
    }

    public interface StandingsStat
    {
        [Required]
        public int? home { get; set; }
        public int? away { get; set; }

        public int? total { get; set; }

        public string percentage { get; set; }

        public int? lastTen { get; set; }

    }


    public class Standings
    {
        [Required]
        public int TeamID { get; set; }
        public int season { get; set;    }
        public StandingsConference conference { get; set; }
        public StandingsDivision division { get; set; }
        public StandingsStat win { get; set; }
        public StandingsStat loss { get; set; }
        public string gamesBehind { get; set; }
        public int? streak { get; set; }
        public bool? winStreak { get; set;  }
        public int? tieBreakerPoints { get; set;  }
    }
}
