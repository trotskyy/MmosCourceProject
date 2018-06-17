using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    public class RepositoryFactory<TEntity, TKey> : 
        GeneralFactoryWithMetadata<IRepository, RepositoryMetadata>, 
        IRepositoryFactory
        where TEntity : class
    {
        public RepositoryFactory(IEnumerable<Lazy<Func<IRepository>, RepositoryMetadata>> instanceDelegatesWithMetaData) 
            : base(instanceDelegatesWithMetaData) { }

        protected override bool CheckMetadata<T>(RepositoryMetadata metadata)
        {
            return metadata.TargetType == typeof(T);
        }

        T IRepositoryFactory.CreateRepository<T>()
        {
            var repository = base.CreateInstance<T>() as T;
            if (repository == null)
                throw new InvalidOperationException($"There is no available repository for type '{typeof(T).FullName}'");
            return repository;
        }
    }
}
