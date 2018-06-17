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
    public abstract class GenericRepository<TEntity, TKey, TDbContext> : GenericReadOnlyRepository<TEntity, TKey, TDbContext>, 
        IRepository<TEntity, TKey>
        where TEntity:class
        where TDbContext : DbContext
    {
        protected abstract void ValidateOnCreate(TEntity entity);
        protected abstract void ValidateOnDelete(TEntity entity);
        protected abstract void ValidateOnUpdate(TEntity entity);

        public GenericRepository(TDbContext dbContext) : base(dbContext)
        {
        }

        public virtual void Create(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            ValidateOnCreate(entity);

            _dbContext.Set<TEntity>().Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            ValidateOnDelete(entity);

            if (_dbContext.Entry<TEntity>(entity).State == EntityState.Detached)
                _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException();

            ValidateOnUpdate(entity);

            _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Entry<TEntity>(entity).State = EntityState.Modified;
        }
    }
}
