using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public TRepository CreateRepository<TRepository, TEntity, TKey>()
            where TRepository : class
            where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
    //public class RepositoryFactory<TEntity, TKey> : 
    //    GeneralFactoryWithMetadata<IRepository<TEntity, TKey>, RepositoryMetadata>, 
    //    IRepositoryFactory
    //    where TEntity : class
    //{
    //    public RepositoryFactory(IEnumerable<Lazy<Func<IRepository<TEntity, TKey>>, RepositoryMetadata>> instanceDelegatesWithMetaData) 
    //        : base(instanceDelegatesWithMetaData) { }

    //    public TRepository CreateRepository<TRepository, TEntity1, TKey1>()
    //        where TRepository : class
    //        where TEntity1 : class
    //    {
    //        throw new NotImplementedException();
    //    }

    //    protected override bool CheckMetadata<T>(RepositoryMetadata metadata)
    //    {
    //        return metadata.TargetType == typeof(T);
    //    }

    //    T IRepositoryFactory.CreateRepository<T>()
    //    {
    //        var repository = base.CreateInstance<T>() as T;
    //        if (repository == null)
    //            throw new InvalidOperationException($"There is no available repository for type '{typeof(T).FullName}'");
    //        return repository;
    //    }
    //}
}
