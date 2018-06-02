using MmosCourseProject.BLL.Utils.DomainModelValidation.Abstract;
using MmosCourseProject.BLL.Utils.DomainModelValidation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Utils.DomainModelValidation
{
    public class Rule<TDbEntity, TUnitOfWork> : IValidationRule<TDbEntity, TUnitOfWork>
        where TDbEntity : class
        where TUnitOfWork : class
    {
        private List<Func<TDbEntity, TUnitOfWork, bool>> _validationRulePredicates;

        private static bool isEntityValid = true;

        public void ValidateRule(TDbEntity entity, TUnitOfWork uow)
        {
            isEntityValid = true;
            this.ThrowingException(new DomainModelConstraintViolationException());
            foreach (var validationPredicate in _validationRulePredicates)
                isEntityValid &= validationPredicate.Invoke(entity, uow);
        }

        public Rule(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
        {
            _validationRulePredicates = new List<Func<TDbEntity, TUnitOfWork, bool>>()
            { validationRulePredicate };
        }

        public IValidationRule<TDbEntity, TUnitOfWork> Including(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
        {
            _validationRulePredicates.Add(validationRulePredicate);
            return this;
        }

        public IValidationRule<TDbEntity, TUnitOfWork> ThrowingException(Exception exception)
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
