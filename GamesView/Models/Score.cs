using System.ComponentModel.DataAnnotations;

namespace GamesView.Models
{
    public class Score
    {
        [Key]
        public int ScoreId { get; set; }
        [Required]
        public int ScoreValue { get; set; }

        public int GameId { get; set; }
        public string? GameName { get; set; }
    }
}
