using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MmosCourseProject.DAL;
using System.Data.Entity.Core.Objects;

namespace MmosCourseProject.DAL.Abstract
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity>
        where TEntity:class
    {
        protected DbContext _dbContext;
        IDbSet<TEntity> _dbSet;

        protected GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate = null)
        {
            if (predicate != null)
            {
                return _dbSet.Where(predicate);
            }

            return _dbSet.AsEnumerable();
        }

        public TEntity Get(Func<TEntity, bool> predicate)
        {
            return _dbSet.First(predicate);
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Attach(TEntity entity)
        {
            _dbSet.Attach(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
