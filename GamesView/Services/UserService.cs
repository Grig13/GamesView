using GamesView.Models;
using GamesView.Repositories.Interfaces;
using GamesView.Services.Interfaces;
using System.Linq.Expressions;

namespace GamesView.Services
{
    public class UserService : IUserService
    {
        private IRepositoryWrapper repositoryWrapper;
        public UserService(IRepositoryWrapper repositoryWrapper)
        {
            this.repositoryWrapper = repositoryWrapper;
        }

        public List<User> GetUsers()
        {
            return repositoryWrapper.UserRepository.FindAll().ToList();
        }

        public List<User> GetUsersByCondition(Expression<Func<User, bool>> expression)
        {
            return repositoryWrapper.UserRepository.FindByCondition(expression).ToList();
        }

        public void AddUser(User user)
        {
            repositoryWrapper.UserRepository.Create(user);
        }

        public void UpdateUser(User user)
        {
            repositoryWrapper.UserRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            repositoryWrapper.UserRepository.Delete(user);
        }

        public void Save()
        {
            repositoryWrapper.Save();
        }
    }
}
