using System.ComponentModel.DataAnnotations;

namespace nba_app.Models
{
    public class BoxScores
    {
        [Required]
        public Game game { get; set; }
        public Team[] teams { get; set; }
        public Player[] players { get; set; }
        public TeamStatGame[] teamGameStats { get; set; }
        public PlayerStatGame[] playerGameStats { get; set; }
    }
}
