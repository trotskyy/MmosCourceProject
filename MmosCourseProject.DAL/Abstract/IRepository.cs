using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.Abstract
{
    public interface IRepository<TEntity, TKey> : IReadOnlyRepository<TEntity, TKey>
        where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        /// <summary>
        /// Note that deleting hierarchical entities leads to deleting all children hierarchy
        /// </summary>
        void Delete(TEntity entity);
    }
}
