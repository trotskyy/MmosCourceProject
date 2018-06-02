using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Utils.DomainModelValidation
{
    public class Rule<TUnitOfWork>
    {
        public Dictionary<Type, MulticastDelegate> ValidationResolver
            = new Dictionary<Type, MulticastDelegate>();

        /// <summary>
        /// Registers validation rule for entity
        /// </summary>
        /// <typeparam name="TDbEntity">database entity</typeparam>
        /// <param name="validationRulePredicate"> return True if valid! Example: uow => {... check that team names with same parent are unique / etc. / using IUnitOfWork ....}</param>
        public void AddValidationRule<TDbEntity>(Func<TDbEntity, TUnitOfWork, bool> validationRulePredicate)
        {
            if (ValidationResolver[typeof(TDbEntity)] == null)
                ValidationResolver.Add(typeof(TDbEntity), validationRulePredicate);
            else
                ValidationResolver[typeof(TDbEntity)] = (MulticastDelegate)
                    Delegate.Combine(ValidationResolver[typeof(TDbEntity)], validationRulePredicate);
        }
    }
}
