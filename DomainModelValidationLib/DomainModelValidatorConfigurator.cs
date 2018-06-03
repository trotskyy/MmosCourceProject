using DomainModelValidation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation
{
    public class DomainModelValidatorConfigurator<TUnitOfWork> : IDomainModelValidatorConfigurator<TUnitOfWork>
        where TUnitOfWork : class
    {
        public DomainModelValidatorConfigurator()
        {
        }

        public RulesSet<TUnitOfWork> OnUpdateRulesSet { get; private set; }
        public RulesSet<TUnitOfWork> OnDeleteRulesSet { get; private set; }
        public RulesSet<TUnitOfWork> OnCreateRulesSet { get; private set; }

        /// <summary>
        /// Configure domain constraints to check before performing UPDATE action
        /// </summary>
        /// <param name="ruleSetInitializingExpression">ruleSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);</param>
        public void ConfigureOnUpdate(Action<IValidationRuleSet<TUnitOfWork>> ruleSetInitializingExpression)
        {
            OnUpdateRulesSet = new RulesSet<TUnitOfWork>(ValidationType.OnUpdate);
            ruleSetInitializingExpression.Invoke(OnUpdateRulesSet);
        }

        /// <summary>
        /// Configure domain constraints to check before performing CREATE action
        /// </summary>
        /// <param name="ruleSetInitializingExpression">ruleSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);</param>
        public void ConfigureOnCreate(Action<IValidationRuleSet<TUnitOfWork>> ruleSetInitializingExpression)
        {
            OnCreateRulesSet = new RulesSet<TUnitOfWork>(ValidationType.OnCreate);
            ruleSetInitializingExpression.Invoke(OnCreateRulesSet);
        }

        /// <summary>
        /// Configure domain constraints to check before performing DELETE action
        /// </summary>
        /// <param name="ruleSetInitializingExpression">ruleSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);</param>
        public void ConfigureOnDelete(Action<IValidationRuleSet<TUnitOfWork>> ruleSetInitializingExpression)
        {
            OnDeleteRulesSet = new RulesSet<TUnitOfWork>(ValidationType.OnDelete);
            ruleSetInitializingExpression.Invoke(OnDeleteRulesSet);
        }

    }
}
