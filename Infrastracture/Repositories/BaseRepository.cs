using Microsoft.EntityFrameworkCore;
using Prohix.Infrastracture.DBContexts;
using Prohix.Infrastracture.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataBaseContext context;
        private bool _disposed;

        public BaseRepository(DataBaseContext context) => this.context = context;

        public IQueryable<TEntity> GetAllAsNoTrackingNoGlobalFilter() => context.Set<TEntity>().AsNoTracking().IgnoreQueryFilters();
        public IQueryable<TEntity> GetAllAsNoTracking() => context.Set<TEntity>().AsNoTracking();
        public IQueryable<TEntity> GetAll() => context.Set<TEntity>();

        #region Asynchronous
        public virtual async Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.FromResult(context.Set<TEntity>().Where(predicate));
        }
        public virtual async Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await context.Set<TEntity>().Where(predicate).FirstOrDefaultAsync();
        }
        public virtual async Task<TEntity> FindAsync(object id)
        {
            return await context.Set<TEntity>().FindAsync(new object[] { id });
        }
        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            return entity;
        }
        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            return await Task.FromResult(entity);
        }
        public virtual async Task<TEntity> RemoveAsync(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            return await Task.FromResult(entity);
        }
        #endregion

        #region Synchronous
        public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate);
        }
        //public virtual TEntity FindOneAsync(Expression<Func<TEntity, bool>> predicate)
        //{
        //    return context.Set<TEntity>().Where(predicate).FirstOrDefault();
        //}
        //public virtual TEntity FindAsync(object id)
        //{
        //    return context.Set<TEntity>().Find(new object[] { id });
        //}
        public virtual TEntity Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            return entity;
        }
        public virtual TEntity Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            return entity;
        }
        public virtual TEntity Remove(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            return entity;
        }


        #endregion
        public async Task<int> SaveChangesAsync()
        {
            try
            {

                var result = await context.SaveChangesAsync();

                return result;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Concurrency_Exception");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveChanges()
        {
            try
            {

                var result = context.SaveChanges();

                return result;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Concurrency_Exception");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
