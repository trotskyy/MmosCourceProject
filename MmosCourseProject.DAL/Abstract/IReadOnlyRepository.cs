using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.Abstract
{
    /// <summary>
    /// Use for views
    /// </summary>
    public interface IReadOnlyRepository<TEntity, TKey>
        where TEntity : class
    {
        IEnumerable<TEntity> GetAll(
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        IEnumerable<Expression<Func<TEntity, object>>> includeProperties = null,
        int? skip = null,
        int? take = null);

        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            IEnumerable<Expression<Func<TEntity, object>>> includeProperties = null,
            int? skip = null,
            int? take = null);

        TEntity GetFirst(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            IEnumerable<Expression<Func<TEntity, object>>> includeProperties = null);

        TEntity GetById(TKey id);

        int GetCount(Expression<Func<TEntity, bool>> filter = null);
    }
}
