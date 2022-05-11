using GamesView.Models;
using GamesView.Repositories.Interfaces;
using GamesView.Services.Interfaces;
using System.Linq.Expressions;

namespace GamesView.Services
{
    public class AdminService : IAdminService
    {
        private IRepositoryWrapper repositoryWrapper;
        public AdminService(IRepositoryWrapper repositoryWrapper)
        {
            this.repositoryWrapper = repositoryWrapper;
        }

        public List<Admin> GetUsers()
        {
            return repositoryWrapper.AdminRepository.FindAll().ToList();
        }

        public List<Admin> GetUsersByCondition(Expression<Func<Admin, bool>> expression)
        {
            return repositoryWrapper.AdminRepository.FindByCondition(expression).ToList();
        }

        public void AddUser(Admin admin)
        {
            repositoryWrapper.AdminRepository.Create(admin);
        }

        public void UpdateUser(Admin admin)
        {
            repositoryWrapper.AdminRepository.Update(admin);
        }

        public void DeleteUser(Admin admin)
        {
            repositoryWrapper.AdminRepository.Delete(admin);
        }

        public void Save()
        {
            repositoryWrapper.Save();
        }
    }
}
