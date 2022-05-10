using System.ComponentModel.DataAnnotations;

namespace GamesView.Models
{
    public class Games
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public string? GameName { get; set; }
        public string? GameGenre { get; set; }
        public int ScoreValue { get; set; }

        public ICollection<Score>? Scores { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
