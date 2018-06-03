using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelValidation.Abstract
{
    public interface IValidationRuleSet<TUnitOfWork>
        where TUnitOfWork : class
    {
        /// <summary>
        /// Violation of this rule will lead to throwing one exception with list of notifications
        /// </summary>
        /// <returns></returns>
        INotificationRuleSet<TUnitOfWork> UsingNotificationApproach();

        /// <summary>
        /// Violation of this rule will lead to throwing an exception per each rule item violation
        /// </summary>
        /// <returns></returns>
        IExceptionRuleSet<TUnitOfWork> UsingExceptionApproach();
    }
}
