using GamesView.Data;
using GamesView.Repositories.Interfaces;

namespace GamesView.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private GamesViewDbContext _dbContext;
        private IReviewRepository _reviewRepository;
        private INewsRepository   _newsRepository;

        public INewsRepository NewsRepository
        {
            get
            {
                if (_newsRepository == null)
                {
                    _newsRepository = new NewsRepository(_dbContext);
                }
                return _newsRepository;
            }
        }

        public IReviewRepository ReviewRepository
        {
            get
            {
                if (_reviewRepository == null)
                {
                    _reviewRepository = new ReviewRepository(_dbContext);
                }
                return _reviewRepository;
            }
        }



        public RepositoryWrapper(GamesViewDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
