using System.ComponentModel.DataAnnotations;

namespace GamesView.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [Required]
        [StringLength(400)]
        public string? ReviewText { get; set; }
        [Required]
        [StringLength(150)]
        public string? GameDescription { get; set; }

        public int UserId { get; set; }
        public int ScoreValue { get; set; }
        public string? GameName { get; set; }

    }
}
