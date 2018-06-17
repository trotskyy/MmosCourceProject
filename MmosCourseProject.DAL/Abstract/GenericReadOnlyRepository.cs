using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace MmosCourseProject.DAL.Abstract
{
    public abstract class GenericReadOnlyRepository<TEntity, TKey, TDbContext> : IReadOnlyRepository<TEntity, TKey>
        where TEntity : class
        where TDbContext : DbContext
    {
        protected TDbContext _dbContext;

        protected IQueryable<TEntity> BuildQuery(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           IEnumerable<Expression<Func<TEntity, object>>> includeProperties = null,
           int? skip = null,
           int? take = null
           )
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            if (filter != null)
                query = query.Where(filter);

            if (includeProperties != null && includeProperties.Count() > 0)
                foreach (var inc in includeProperties)
                    query = query.Include(inc);

            if (orderBy != null)
                query = orderBy(query);

            return query;
        }

        public GenericReadOnlyRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null, 
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, 
            IEnumerable<Expression<Func<TEntity, object>>> includeProperties = null, 
            int? skip = null, 
            int? take = null)
        {
            return BuildQuery(filter, orderBy, includeProperties, skip, take).AsEnumerable();
        }

        public IEnumerable<TEntity> GetAll(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, IEnumerable<Expression<Func<TEntity, object>>> includeProperties = null, int? skip = null, int? take = null)
        {
            return BuildQuery(null, orderBy, includeProperties, skip, take).AsEnumerable();
        }

        public TEntity GetById(TKey id)
        {
            if (id == null || id.Equals(default(TKey)))
                throw new ArgumentNullException();
            return _dbContext.Set<TEntity>().Find(id);
        }

        public int GetCount(Expression<Func<TEntity, bool>> filter = null)
        {
            return BuildQuery(filter: filter).Count();
        }

        public TEntity GetFirst(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, IEnumerable<Expression<Func<TEntity, object>>> includeProperties = null)
        {
            return BuildQuery(filter, orderBy, includeProperties, null, null).FirstOrDefault();
        }

       

       
    }
}
