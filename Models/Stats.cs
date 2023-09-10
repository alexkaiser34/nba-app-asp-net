namespace nba_app.Models
{

    public class Stats
    {
        public int? points { get; set; }
        public int? fgm { get; set; }
        public int? fga { get; set; }
        public string fgp { get; set; }

        public int? ftm { get; set; }
        public int? fta { get; set; }
        public string ftp { get; set;  }

        public int? tpm { get; set; }
        public int? tpa { get; set; }
        public string tpp { get; set; }

        public int? offReb { get; set; }
        public int? defReb { get; set; }

        public int? totReb { get; set; }
        public int? assists { get; set; }

        public int? pFouls { get; set; }

        public int? steals { get; set;  }

        public int? turnovers { get; set; }

        public int? blocks { get; set; }

        public string plusMinus { get; set; }

    }

    public class TeamStat : Stats
    {
        public int TeamID { get; set; }

        public int? fastBreakPoints { get; set; }
        public int? pointsInPaint { get; set; }

        public int? biggestLead { get; set; }

        public int? secondChancePoints { get; set; }

        public int? pointsOffTurnovers { get; set; }

        public int? longestRun { get; set;  }
    }

    public class PlayerStatGame : Stats
    {
        public int PlayerID { get; set; }
        public int GameID { get; set; }
        public int TeamID { get; set; }

        public string min { get; set; }
    }

    public class TeamStatGame : TeamStat
    {
        public string min { get; set; }
        public int GameID { get; set; }
    }

    public class TeamStatSeason : TeamStat
    {
        public int games { get; set; }

        public int season { get; set; }
    }


}
