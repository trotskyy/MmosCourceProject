using DomainModelValidation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation
{
    public class ExceptionRule<TDbEntity, TUnitOfWork> : Rule<TDbEntity, TUnitOfWork>, 
        IExceptionRule<TDbEntity, TUnitOfWork>
        where TDbEntity : class
        where TUnitOfWork : class
    {
        public ExceptionRule(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate) : base(validationRulePredicate)
        {
            //_basicException = new Exception("Basic exception");
        }

        public IExceptionRule<TDbEntity, TUnitOfWork> Including(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
        {
            return (IExceptionRule<TDbEntity, TUnitOfWork>)BasicIncluding(validationRulePredicate);
        }

        public IExceptionRule<TDbEntity, TUnitOfWork> ThrowingException(Exception exception)
        {
            return (IExceptionRule<TDbEntity, TUnitOfWork>)BasicIncluding((dbEntity, uow) =>
            {
                if (!isEntityValid)
                    throw exception;
                else
                    return true;
            });
        }
    }
}
