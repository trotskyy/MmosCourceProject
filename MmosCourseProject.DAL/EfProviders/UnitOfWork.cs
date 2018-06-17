using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    /// <summary>
    /// Entity Framework unit of work
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        DbContext _dbContext;
        IRepositoryFactory _repositoryFactory;
        IDictionary<Type, object> _repositoryCache;

        public UnitOfWork()
        {

        }

        //public UnitOfWork(DbContext dbContext, IRepositoryFactory repositoryFactory)
        //{
        //    _dbContext = dbContext;
        //    _repositoryFactory = repositoryFactory;
        //    _repositoryCache = new Dictionary<Type, object>();
        //}

        T IUnitOfWork.Repository<T>()
        {
            Type repositoryType = typeof(T);
            if (_repositoryCache.Keys.Contains(repositoryType))
                return _repositoryCache[repositoryType] as T;
            var repository = _repositoryFactory.CreateRepository<T>();
            _repositoryCache.Add(repositoryType, repository);
            return repository;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
