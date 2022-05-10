using System.Linq.Expressions;
using System;

namespace GamesView.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        ICollection<T> GetAll();
        T Create(T entity);
        void Delete(T entity);
        T Update(T entity);
    }
}
