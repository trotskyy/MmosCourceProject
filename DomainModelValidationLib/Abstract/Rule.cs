using DomainModelValidation.Abstract;
using DomainModelValidation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation.Abstract
{
    public abstract class Rule<TDbEntity, TUnitOfWork> //: IExceptionRule<TDbEntity, TUnitOfWork>
        where TDbEntity : class
        where TUnitOfWork : class
    {
        private List<Func<TDbEntity, TUnitOfWork, bool>> _validationRulePredicates;

        [ThreadStatic]
        protected static bool isEntityValid;

        protected Exception _basicException;

        public void ValidateRule(TDbEntity entity, TUnitOfWork uow)
        {
            isEntityValid = true;
            this.BasicThrowingException(_basicException);
            foreach (var validationPredicate in _validationRulePredicates)
                isEntityValid &= validationPredicate.Invoke(entity, uow);
        }

        public Rule(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
        {
            _basicException = 
                new DomainModelConstraintViolationException($"Validation for entity of type {typeof(TDbEntity).Name} on data source of type {typeof(TUnitOfWork).Name} failed");

            _validationRulePredicates = new List<Func<TDbEntity, TUnitOfWork, bool>>()
            { validationRulePredicate };
        }

        protected Rule<TDbEntity, TUnitOfWork> BasicIncluding(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
        {
            _validationRulePredicates.Add(validationRulePredicate);
            return this;
        }

        public Rule<TDbEntity, TUnitOfWork> BasicThrowingException(Exception exception)
        {
            _validationRulePredicates.Add((dbEntity, uow) =>
            {
                if (!isEntityValid)
                    throw exception;
                else
                    return true;
            });
            return this;
        }
    }
}
