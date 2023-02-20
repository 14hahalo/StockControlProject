using StockControlProject.Domain.Entities;
using System.Linq.Expressions;

namespace StockControlProject.Repository.Abstract
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        bool Add(T item);
        bool Add(List<T> items);
        bool Update(T item);
        bool Remove(T item);
        bool RemoveAll(Expression<Func<T,bool>> exp);
        T GetByID(int id);
        IQueryable<T> GetByID(int id,params Expression<Func<T, object>>[] includes);
        T GetByDefault(Expression<Func<T, bool>> exp);
        List<T> GetActive();
        IQueryable<T> GetActive(params Expression<Func<T, object>>[] includes);
        List<T> GetDefault(Expression<Func<T, bool>> exp);
        List<T> GetAll();
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes); 
        bool Activate(int id);
        bool Any(Expression<Func<T, bool>> exp);
        int Save();
        void DetachEntity(T item);

    }
}
