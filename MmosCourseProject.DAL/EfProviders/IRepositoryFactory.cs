using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    public interface IRepositoryFactory
    {
        TRepository CreateRepository<TRepository, TEntity, TKey>() 
            where TRepository : class
            where TEntity : class;
    }
}
