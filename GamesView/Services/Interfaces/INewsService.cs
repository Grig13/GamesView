using GamesView.Models;
using System.Linq.Expressions;

namespace GamesView.Services.Interfaces
{
    public interface INewsService
    {
        List<News> GetUsers();
        List<News> GetUsersByCondition(Expression<Func<News, bool>> expression);
        void AddUser(News news);
        void UpdateUser(News news);
        void DeleteUser(News news);
        void Save();
    }
}
