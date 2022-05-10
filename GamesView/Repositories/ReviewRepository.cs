using GamesView.Data;
using GamesView.Models;
using GamesView.Repositories.Interfaces;

namespace GamesView.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(GamesViewDbContext dbContext) : base(dbContext)
        {
        }
    }
}
