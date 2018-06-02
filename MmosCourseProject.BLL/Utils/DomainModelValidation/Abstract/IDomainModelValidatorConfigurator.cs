using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Utils.DomainModelValidation.Abstract
{
    /// <summary>
    /// Represents a set of rules devided by operation types
    /// </summary>
    public interface IDomainModelValidatorConfigurator<TUnitOfWork>
    {
        /// <summary>
        /// Configure domain constraints to check before performing UPDATE action
        /// </summary>
        /// <param name="ruleSetInitializingExpression">ruleSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);</param>
        void ConfigureOnUpdate(Action<IValidationRuleSet<TUnitOfWork>> ruleSetInitializingExpression);

        /// <summary>
        /// Configure domain constraints to check before performing CREATE action
        /// </summary>
        /// <param name="ruleSetInitializingExpression">ruleSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);</param>
        void ConfigureOnCreate(Action<IValidationRuleSet<TUnitOfWork>> ruleSetInitializingExpression);

        /// <summary>
        /// Configure domain constraints to check before performing DELETE action
        /// </summary>
        /// <param name="ruleSetInitializingExpression">ruleSet.AddValidationRule<User>((user, uow) => uow.UserRepository.GetById(user.Id) == null);</param>
        void ConfigureOnDelete(Action<IValidationRuleSet<TUnitOfWork>> ruleSetInitializingExpression);
    }
}
