using GamesView.Models;
using System.Linq.Expressions;

namespace GamesView.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetUsers();
        List<User> GetUsersByCondition(Expression<Func<User, bool>> expression);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        void Save();
    }
}
