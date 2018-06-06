using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL;
using System.Data.Entity;

namespace MmosCourseProject.DAL.Abstract
{
    public abstract class GenericViewRepository<TEntity, TKey> : IViewRepository<TEntity, TKey>
        where TEntity:class
    {
        private DbContext _dbContext;

        protected GenericViewRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public TEntity GetById(TKey id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }
    }
}
