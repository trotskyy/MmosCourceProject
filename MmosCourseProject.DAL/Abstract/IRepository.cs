using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.Abstract
{
    public interface IRepository<TEntity> : IRepository
    {
        TEntity Get(Func<TEntity, bool> predicate);
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate = null);
        void Add(TEntity entity);
        void Attach(TEntity entity);
        /// <summary>
        /// Note that deleting hierarchical entities leads to deleting all children hierarchy
        /// </summary>
        void Delete(TEntity entity);
    }

    public interface IRepository { }
}
