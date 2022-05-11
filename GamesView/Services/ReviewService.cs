using GamesView.Models;
using GamesView.Repositories.Interfaces;
using GamesView.Services.Interfaces;
using System.Linq.Expressions;

namespace GamesView.Services
{
    public class ReviewService : IReviewService
    {
        private IRepositoryWrapper repositoryWrapper;
        public ReviewService(IRepositoryWrapper repositoryWrapper)
        {
            this.repositoryWrapper = repositoryWrapper;
        }

        public List<Review> GetUsers()
        {
            return repositoryWrapper.ReviewRepository.FindAll().ToList();
        }

        public List<Review> GetUsersByCondition(Expression<Func<Review, bool>> expression)
        {
            return repositoryWrapper.ReviewRepository.FindByCondition(expression).ToList();
        }

        public void AddUser(Review review)
        {
            repositoryWrapper.ReviewRepository.Create(review);
        }

        public void UpdateUser(Review review)
        {
            repositoryWrapper.ReviewRepository.Update(review);
        }

        public void DeleteUser(Review review)
        {
            repositoryWrapper.ReviewRepository.Delete(review);
        }

        public void Save()
        {
            repositoryWrapper.Save();
        }
    }
}
