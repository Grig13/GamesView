using GamesView.Models;
using GamesView.Repositories.Interfaces;
using GamesView.Services.Interfaces;
using System.Linq.Expressions;

namespace GamesView.Services
{
    public class NewsService : INewsService
    {
        private IRepositoryWrapper repositoryWrapper;
        public NewsService(IRepositoryWrapper repositoryWrapper)
        {
            this.repositoryWrapper = repositoryWrapper;
        }

        public List<News> GetUsers()
        {
            return repositoryWrapper.NewsRepository.FindAll().ToList();
        }

        public List<News> GetUsersByCondition(Expression<Func<News, bool>> expression)
        {
            return repositoryWrapper.NewsRepository.FindByCondition(expression).ToList();
        }

        public void AddUser(News news)
        {
            repositoryWrapper.NewsRepository.Create(news);
        }

        public void UpdateUser(News news)
        {
            repositoryWrapper.NewsRepository.Update(news);
        }

        public void DeleteUser(News news)
        {
            repositoryWrapper.NewsRepository.Delete(news);
        }

        public void Save()
        {
            repositoryWrapper.Save();
        }
    }
}
