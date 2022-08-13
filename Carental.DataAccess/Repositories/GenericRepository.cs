using Carental.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Carental.DataAccess.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected CarentalContext CarentalContext { get; set; }
        public GenericRepository(CarentalContext carentalContext)
        {
            CarentalContext = carentalContext;
        }
        public IQueryable<T> GetAll() => CarentalContext.Set<T>().AsNoTracking();
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression) =>
            CarentalContext.Set<T>().Where(expression).AsNoTracking();
        public void Add(T entity) => CarentalContext.Set<T>().Add(entity);
        public void Update(T entity) => CarentalContext.Set<T>().Update(entity);
        public void Delete(T entity) => CarentalContext.Set<T>().Remove(entity);
    }
}
