using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.Abstract
{
    public interface IRepository<TEntity, TKey>
    {
        TEntity GetById(TKey id);
        List<TEntity> GetAll();
        void Create(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
