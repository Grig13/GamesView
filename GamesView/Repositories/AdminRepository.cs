using GamesView.Data;
using GamesView.Models;
using GamesView.Repositories.Interfaces;

namespace GamesView.Repositories
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(GamesViewDbContext dbContext) : base(dbContext)
        {
        }
    }
}
