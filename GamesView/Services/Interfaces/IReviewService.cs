using GamesView.Models;
using System.Linq.Expressions;

namespace GamesView.Services.Interfaces
{
    public interface IReviewService
    {
        List<Review> GetUsers();
        List<Review> GetUsersByCondition(Expression<Func<Review, bool>> expression);
        void AddUser(Review review);
        void UpdateUser(Review review);
        void DeleteUser(Review review);
        void Save();
    }
}
