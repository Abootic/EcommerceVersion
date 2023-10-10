using System.Linq.Expressions;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAll(int skip,int take);
        Task<IEnumerable<R>> GetAll<R>(Expression<Func<T,R>> selector);
        Task<IEnumerable<R>> GetAll<R>(Expression<Func<T,R>> selector,int skip,int take);
        Task<T> GetById(int Id);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        Task<IEnumerable<R>> Find<R>(Expression<Func<T, R>> Selector,Expression<Func<T,bool>> expression);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression,int skip,int take);
        Task<IEnumerable<R>> Find<R>(Expression<Func<T, R>> Selector, Expression<Func<T, bool>> expression,int skip,int take);
        Task Add(T entity);
        Task<T> AddAndReturn(T entity);
         Task<T> Remove(T entity);
        Task<T> Update(T entity);
        Task<int> SaveChange();


    }
}
