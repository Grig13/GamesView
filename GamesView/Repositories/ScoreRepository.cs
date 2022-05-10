using GamesView.Data;
using GamesView.Models;
using GamesView.Repositories.Interfaces;

namespace GamesView.Repositories
{
    public class ScoreRepository : BaseRepository<Score>, IScoreRepository
    {
        public ScoreRepository(GamesViewDbContext dbContext) : base(dbContext)
        {
        }
    }
}
