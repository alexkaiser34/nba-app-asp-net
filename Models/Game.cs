using System.ComponentModel.DataAnnotations;

namespace nba_app.Models
{
    public class GameDate
    {
        [Required]
        public string start { get; set; }
        public string end { get; set; }
        public string duration { get; set; }
    }

    public class GameStatus
    {
        [Required]
        public string clock { get; set; }
        public bool? halftime { get; set; }
        public int? Short { get; set; }
        public string Long { get; set; }
    }

    public class GameArena
    {
        [Required]
        public string name { get; set; }
        public string city { get; set; }

        public string state { get; set; }
        public string country { get; set; }
    }

    public class GamesTeams
    {
        [Required]
        public int awayTeamID { get; set; }
        public int homeTeamID { get; set; }
    }

    public class ScoreSeries
    {
        [Required]
        public int win { get; set; }
        public int loss { get; set;  }

    }

    public class ScoreData
    {
        [Required]
        public int win { get; set; }
        public int loss { get; set; }
        public ScoreSeries series { get; set; }
        public int[]? lineScore { get; set; }
        public int? points { get; set; }

    }

    public class GamesScores
    {
        [Required]
        public ScoreData visitors { get; set; }
        public ScoreData home { get; set; }
    }


    public class Game
    {
        [Required]
        public int id { get; set;  }

        public int season { get; set; }
        public GameDate date { get; set; }
        public GameStatus status { get; set; }
        public GameArena arena { get; set; }

        public GamesTeams teams { get; set; }

        public GamesScores scores { get; set; }
        public int? timesTied { get; set;  }
        public int? leadChanges { get; set; }

    }
}
