using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    public abstract class GeneralFactoryWithMetadata<TReturn, TMetadata>
    {
        protected IEnumerable<Lazy<Func<TReturn>, TMetadata>> _instanceDelegatesWithMetaData;

        protected GeneralFactoryWithMetadata(IEnumerable<Lazy<Func<TReturn>, TMetadata>> instanceDelegatesWithMetaData)
        {
            _instanceDelegatesWithMetaData = instanceDelegatesWithMetaData;
        }

        protected TReturn CreateInstance<T>()
        {
            var instanceCreatorDelegate = _instanceDelegatesWithMetaData.FirstOrDefault(x => CheckMetadata<T>(x.Metadata));
            if (instanceCreatorDelegate == null)
                throw new InvalidOperationException($"There is no available delegate for type '{typeof(T).FullName}'");
            var createInstance = instanceCreatorDelegate.Value;
            var instance = createInstance();
            return instance;
        }

        protected abstract bool CheckMetadata<T>(TMetadata metadata);
    }
}
