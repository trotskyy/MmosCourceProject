using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation.Abstract
{
    public interface INotificationRule<out TDbEntity, TUnitOfWork> : IValidationRule<TDbEntity, TUnitOfWork>
        where TDbEntity : class
        where TUnitOfWork : class
    {
        /// <summary>
        /// Combine with another validation rule
        /// </summary>
        /// <param name="validationRulePredicate">E.g. (user, uow) => uow.UserRepository.GetById(user.Id) == null</param>
        INotificationRule<TDbEntity, TUnitOfWork> Including(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate);

        /// <summary>
        /// Define notification for violation of previous rule
        /// </summary>
        INotificationRule<TDbEntity, TUnitOfWork> NotifiedAs(Notification notification);

        /// <summary>
        /// Define message of DomainModelConstraintViolationException for this rule
        /// </summary>
        /// <param name="message"></param>
        void WithValidationExceptionMessage(string message);
    }
}
