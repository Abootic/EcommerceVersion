using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Infrastraction.Data;

namespace EcommereceWeb.Infrstraction.Repositories
{
    public abstract class GenirecRopoistories<T>: IGenericRepository<T> where T : class
    {
        public ApplicationDbContext _dbContext;
        public GenirecRopoistories(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> GetById(int Id)
        {
            return await _dbContext.Set<T>().FindAsync(Id);
      
        }
        public IQueryable<T> Entities => _dbContext.Set<T>().AsNoTracking();

        public async Task Add(T entity)
        {
           await _dbContext.Set<T>().AddAsync(entity);         
        }

        public async Task<T> AddAndReturn(T entity)
        {
            var res = await _dbContext.Set<T>().AddAsync(entity);
            return res.Entity;
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return await _dbContext.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<R>> Find<R>(Expression<Func<T, R>> Selector, Expression<Func<T, bool>> expression)
        {
            return await _dbContext.Set<T>().Where(expression).Select(Selector).ToListAsync();
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression, int skip, int take)
        {
            return await _dbContext.Set<T>().Where(expression).Skip(skip).Take(take).ToListAsync();
        }

        public async Task<IEnumerable<R>> Find<R>(Expression<Func<T, R>> Selector, Expression<Func<T, bool>> expression, int skip, int take)
        {
            return await _dbContext.Set<T>().Where(expression).Select(Selector).Skip(skip).Take(take).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await  _dbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(int skip, int take)
        {
            return await _dbContext.Set<T>().AsNoTracking().Skip(skip).Take(take).ToListAsync();
        }

        public async Task<IEnumerable<R>> GetAll<R>(Expression<Func<T, R>> selector)
        {
            return await _dbContext.Set<T>().AsNoTracking().Select(selector).ToListAsync();
        }

        public async Task<IEnumerable<R>> GetAll<R>(Expression<Func<T, R>> selector, int skip, int take)
        {
            return await _dbContext.Set<T>().AsNoTracking().Select(selector).Skip(skip).Take(take).ToListAsync();
        }

        public async Task<T> Remove(T entity)
        {
            var res= _dbContext.Set<T>().Remove(entity);
         return   res.Entity;
            
        }

        public async Task<int> SaveChange()
        {
         var res=await  _dbContext.SaveChangesAsync();
            return res;
        }

        public async Task<T> Update(T entity)
        {
            var res=  _dbContext.Set<T>().Update(entity);
            return res.Entity;
        }
    }
}
