using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation.Abstract
{
    /// <summary>
    /// Represents a set of rules
    /// ATTENTION - One rule per entity type in set
    /// </summary>
    public interface IValidationRuleSet<TUnitOfWork>
        where TUnitOfWork : class
    {
        /// <summary>
        /// Add a validation rule to set
        /// </summary>
        /// <typeparam name="TDbEntity">Entity for wich validation rule is created</typeparam>
        /// <param name="validationRulePredicate">E.g. (user, uow) => uow.UserRepository.GetById(user.Id) == null</param>
        /// <returns></returns>
        IValidationRule<TDbEntity, TUnitOfWork> AddRule<TDbEntity>(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
            where TDbEntity : class;
    }
}
