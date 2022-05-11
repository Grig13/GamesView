using GamesView.Models;
using System.Linq.Expressions;

namespace GamesView.Services.Interfaces
{
    public interface IAdminService
    {
        List<Admin> GetUsers();
        List<Admin> GetUsersByCondition(Expression<Func<Admin, bool>> expression);
        void AddUser(Admin admin);
        void UpdateUser(Admin admin);
        void DeleteUser(Admin admin);
        void Save();
    }
}
