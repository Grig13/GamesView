using GamesView.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace GamesView.Data
{
    public class GamesViewDbContext : IdentityDbContext<IdentityUser>
    {
        public GamesViewDbContext(DbContextOptions<GamesViewDbContext> options) : base(options)
        {

        }

        public DbSet<Games>? Gamess { get; set; }
        public DbSet<News>? Newss { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<Score>? Scores { get; set; }


    }
}
