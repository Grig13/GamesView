using GamesView.Data;
using GamesView.Models;
using GamesView.Repositories.Interfaces;

namespace GamesView.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(GamesViewDbContext dbContext) : base(dbContext)
        {

        }
    }
}
