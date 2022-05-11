using GamesView.Data;
using GamesView.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using GamesView.Models;

namespace GamesView.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected GamesViewDbContext dbContext { get; set; }

        public BaseRepository(GamesViewDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.dbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.dbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.dbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.dbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.dbContext.Set<T>().Remove(entity);
        }
    }
}
