using System.Linq.Expressions;

namespace Carental.DataAccess.Repositories.Interfaces
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> GetAll();
        T? GetById(Guid id);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
