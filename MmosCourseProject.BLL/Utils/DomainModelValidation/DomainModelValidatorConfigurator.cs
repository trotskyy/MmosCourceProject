using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Utils.DomainModelValidation
{
    public class DomainModelValidatorConfigurator<TUnitOfWork>
    {
        public DomainModelValidatorConfigurator(RulesSet<TUnitOfWork> onUpdateRulesSet, RulesSet<TUnitOfWork> onDeleteRulesSet, RulesSet<TUnitOfWork> onCreateRulesSet)
        {
            OnUpdateRulesSet = onUpdateRulesSet;
            OnDeleteRulesSet = onDeleteRulesSet;
            OnCreateRulesSet = onCreateRulesSet;
        }

        public RulesSet<TUnitOfWork> OnUpdateRulesSet { get; private set; }
        public RulesSet<TUnitOfWork> OnDeleteRulesSet { get; private set; }
        public RulesSet<TUnitOfWork> OnCreateRulesSet { get; private set; }

        /// <summary>
        /// Configure domain constraints to check before performing UPDATE action
        /// </summary>
        /// <param name="ruleSetInitializingExpression">ruleSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);</param>
        public void ConfigureOnUpdate(Action<RulesSet<TUnitOfWork>> ruleSetInitializingExpression)
        {
            ruleSetInitializingExpression.Invoke(OnUpdateRulesSet);
        }

        /// <summary>
        /// Configure domain constraints to check before performing CREATE action
        /// </summary>
        /// <param name="ruleSetInitializingExpression">ruleSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);</param>
        public void ConfigureOnCreate(Action<RulesSet<TUnitOfWork>> ruleSetInitializingExpression)
        {
            ruleSetInitializingExpression.Invoke(OnCreateRulesSet);
        }

        /// <summary>
        /// Configure domain constraints to check before performing DELETE action
        /// </summary>
        /// <param name="ruleSetInitializingExpression">ruleSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);</param>
        public void ConfigureOnDeletee(Action<RulesSet<TUnitOfWork>> ruleSetInitializingExpression)
        {
            ruleSetInitializingExpression.Invoke(OnDeleteRulesSet);
        }

    }
}
