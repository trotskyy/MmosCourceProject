using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.BLL.Services.DomainConstraintsValidatiotors
{
    //stratagy pattern IBehavior
    
    /// <summary>
    /// Checks if entity violates domain constraints (foreign keys, unique name) which are manualy checked. Use before insert or update operations
    /// </summary>
    /// <typeparam name="DbEntity">Database entity</typeparam>
    public interface IDomainConstraintsValidator<DbEntity>
    {
        /// <summary>
        /// Check manualy if entity violates domain constraints (foreign keys, unique name). Use before insert or update operations
        /// </summary>
        /// <param name="entity">Сущность, которую мы валидируем</param>
        /// <param name="uow">Юнит оф ворк, в контексте которого идет запрос</param>
        /// <exception cref="MmosCourseProject.BLL.Exceptions.DomainConstraintViolationException">Thrown when entity violates domain constraints (foreign keys, unique name) which manualy checked</exception>
        void ValidateDomainConstraints(DbEntity entity, IUnitOfWork uow);
    }
}
