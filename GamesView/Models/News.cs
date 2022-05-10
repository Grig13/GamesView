using System.ComponentModel.DataAnnotations;

namespace GamesView.Models
{
    public class News
    {
        [Key]
        public int NewsId { get; set; }
        public string? Name { get; set; }
        [StringLength(100)]
        public string? Link { get; set; }

    }
}
