using System.ComponentModel.DataAnnotations;

namespace GamesView.Models
{
    public class Admin
    {
        [Key]
        public int? AdminId { get; set; }
        [Required]
        [StringLength(15)]
        public string? Username { get; set; }
        [Required]
        [StringLength(15)]
        public string? Password { get; set; }

    }
}
