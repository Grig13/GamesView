using GamesView.Models;
using Microsoft.EntityFrameworkCore;


namespace GamesView.Data
{
    public class GamesViewDbContext : DbContext
    {
        public GamesViewDbContext(DbContextOptions<GamesViewDbContext> options) : base(options)
        {

        }

        public DbSet<Admin>? Admins { get; set; }
        public DbSet<Games>? Gamess { get; set; }
        public DbSet<News>? Newss { get; set; }
        public DbSet<Review>? Reviews { get; set; }
        public DbSet<Score>? Scores { get; set; }
        public DbSet<User>? Users { get; set; }


    }
}
