using GamesView.Data;
using GamesView.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using GamesView.Models;

namespace GamesView.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly GamesViewDbContext _dbContext;

        public BaseRepository(GamesViewDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public T Create(T entity)
        {
            var returnEntity = _dbContext.Set<T>().Add(entity).Entity;
            _dbContext.SaveChanges();
            return returnEntity;
        }

        public T Update(T entity)
        {
            var itemUpdate = _dbContext.Set<T>().Update(entity).Entity;
            _dbContext.SaveChanges();
            return itemUpdate;
        }

        public void Delete(T entity)
        {
            this._dbContext.Set<T>().Remove(entity);
        }

        public ICollection<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }
    }
}
