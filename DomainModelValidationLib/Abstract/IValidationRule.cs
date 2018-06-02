using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation.Abstract
{
    /// <summary>
    /// Represents a set of validation predicates, wich are combined and invoked in order of adding. 
    /// In case of rule violation exception will be thrown
    /// ATTENTION - One rule per entity type in set
    /// </summary>
    /// <typeparam name="TDbEntity">Data Entity wich must be checked</typeparam>
    /// <typeparam name="TUnitOfWork">Data source</typeparam>
    public interface IValidationRule<out TDbEntity, TUnitOfWork>
        where TDbEntity : class
        where TUnitOfWork : class
    {
        /// <summary>
        /// Combine with another validation rule
        /// </summary>
        /// <param name="validationRulePredicate">E.g. (user, uow) => uow.UserRepository.GetById(user.Id) == null</param>
        IValidationRule<TDbEntity, TUnitOfWork> Including(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate);

        /// <summary>
        /// Define exception which will be thrown in case of validation rules violation. Default exception if not set
        /// </summary>
        IValidationRule<TDbEntity, TUnitOfWork> ThrowingException(Exception exception);
    }
}
