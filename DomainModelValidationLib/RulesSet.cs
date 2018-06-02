using DomainModelValidation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation
{
    /// <summary>
    /// Represent a set of validation rules
    /// </summary>
    public class RulesSet<TUnitOfWork> : IValidationRuleSet<TUnitOfWork>
        where TUnitOfWork : class
    {
        private Dictionary<Type, IValidationRule<object, TUnitOfWork>> _rules = 
            new Dictionary<Type, IValidationRule<object, TUnitOfWork>>();

        public Rule<TDbEntity, TUnitOfWork> GetValidationRule<TDbEntity>()
            where TDbEntity : class
        {
            return (Rule<TDbEntity, TUnitOfWork>)_rules[typeof(TDbEntity)];
        }

        /// <summary>
        /// Registers validation rule for entity
        /// </summary>
        /// <typeparam name="TDbEntity">database entity</typeparam>
        /// <param name="validationRulePredicate"> return True if valid! Example: uow => {... check that team names with same parent are unique / etc. / using IUnitOfWork ....}</param>
        public IValidationRule<TDbEntity, TUnitOfWork> AddRule<TDbEntity>(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
            where TDbEntity : class
        {
            var newRule = new Rule<TDbEntity, TUnitOfWork>(validationRulePredicate);
            _rules.Add(typeof(TDbEntity), newRule);
            return newRule;
        }
    }
}
