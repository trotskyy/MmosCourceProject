using DomainModelValidation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModelValidation.Exceptions;

namespace DomainModelValidation
{
    /// <summary>
    /// Represent a set of validation rules
    /// </summary>
    public class RulesSet<TUnitOfWork> : IValidationRuleSet<TUnitOfWork>, 
        IExceptionRuleSet<TUnitOfWork>, 
        INotificationRuleSet<TUnitOfWork>
        where TUnitOfWork : class
    {
        private Dictionary<Type, IValidationRule<object, TUnitOfWork>> _rules = 
            new Dictionary<Type, IValidationRule<object, TUnitOfWork>>();
        private ValidationType _validationType;

        public RulesSet(ValidationType validationType)
        {
            _validationType = validationType;
        }

        public Rule<TDbEntity, TUnitOfWork> GetValidationRule<TDbEntity>()
            where TDbEntity : class
        {
            return (Rule<TDbEntity, TUnitOfWork>)_rules[typeof(TDbEntity)];
        }

        public IExceptionRuleSet<TUnitOfWork> UsingExceptionApproach()
        {
            return this;
        }

        public INotificationRuleSet<TUnitOfWork> UsingNotificationApproach()
        {
            return this;
        }

        private void CheckAttribute<TDbEntity>()
        {
            var validateAttribute = (ValidateDomainConstraintsAttribute)typeof(TDbEntity)
                .GetCustomAttributes(typeof(ValidateDomainConstraintsAttribute), false)
                .FirstOrDefault();
            if (validateAttribute == null)
                throw new DomainModelValidatorConfigurationException("Mark entity with [ValidateDomainConstraints] to set as a validation rule for it");
            if((validateAttribute.GetValidationType() & _validationType) != _validationType)
                throw new DomainModelValidatorConfigurationException("Validation type of entity set in [ValidateDomainConstraints] does not match with validation method");
        }

        IExceptionRule<TDbEntity, TUnitOfWork> IExceptionRuleSet<TUnitOfWork>.AddRule<TDbEntity>(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
        {
            CheckAttribute<TDbEntity>();

            var newRule = new ExceptionRule<TDbEntity, TUnitOfWork>(validationRulePredicate);
            _rules.Add(typeof(TDbEntity), newRule);
            return newRule;
        }

        INotificationRule<TDbEntity, TUnitOfWork> INotificationRuleSet<TUnitOfWork>.AddRule<TDbEntity>(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
        {
            CheckAttribute<TDbEntity>();

            var newRule = new NotificationRule<TDbEntity, TUnitOfWork>(validationRulePredicate);
            _rules.Add(typeof(TDbEntity), newRule);
            return newRule;
        }
    }
}
