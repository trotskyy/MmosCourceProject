using DomainModelValidation.Abstract;
using DomainModelValidation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation
{
    public class NotificationRule<TDbEntity, TUnitOfWork> : Rule<TDbEntity, TUnitOfWork>, 
        INotificationRule<TDbEntity, TUnitOfWork>
        where TDbEntity : class
        where TUnitOfWork : class
    {
        public NotificationRule(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate) : base(validationRulePredicate)
        {
            _basicException = 
                new DomainModelConstraintViolationException($"Validation for entity of type {typeof(TDbEntity).Name} on data source of type {typeof(TUnitOfWork).Name} failed. Watch 'ValidationMessage' and 'Notifications' for more info");
        }

        public INotificationRule<TDbEntity, TUnitOfWork> Including(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
        {
            return (INotificationRule<TDbEntity, TUnitOfWork>)BasicIncluding(validationRulePredicate);
        }

        public INotificationRule<TDbEntity, TUnitOfWork> NotifiedAs(Notification notification)
        {
            return (INotificationRule<TDbEntity, TUnitOfWork>)BasicIncluding((entity, uow) =>
            {
                if (!isEntityValid)
                    ((DomainModelConstraintViolationException)_basicException).Notifications.Add(notification);

                return true;
            });
        }

        public void WithValidationExceptionMessage(string message)
        {
            ((DomainModelConstraintViolationException)_basicException).ValidationMessage = message;
        }
    }
}
