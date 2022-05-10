using System.ComponentModel.DataAnnotations;

namespace GamesView.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [StringLength(15)]
        public string? Username { get; set; }
        [Required]
        [StringLength(15)]
        public string? Password { get; set; }

        public ICollection<Score>? Scores { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
