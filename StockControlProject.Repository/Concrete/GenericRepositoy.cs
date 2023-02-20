using StockControlProject.Domain.Entities;
using StockControlProject.Repository.Abstract;
using System.Linq.Expressions;

namespace StockControlProject.Repository.Concrete
{
    public class GenericRepositoy<T> : IGenericRepository<T> where T : BaseEntity
    {
        public bool Activate(int id)
        {
            throw new NotImplementedException();
        }

        public bool Add(T item)
        {
            throw new NotImplementedException();
        }

        public bool Add(List<T> items)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public void DetachEntity(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetActive()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetActive(params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetByID(int id, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAll(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
