using GamesView.Data;
using GamesView.Models;
using GamesView.Repositories.Interfaces;

namespace GamesView.Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        public NewsRepository(GamesViewDbContext dbContext) : base(dbContext)
        {

        }
    }
    
}
