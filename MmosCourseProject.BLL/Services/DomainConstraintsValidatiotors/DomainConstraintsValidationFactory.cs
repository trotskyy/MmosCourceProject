using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MmosCourseProject.DAL;

namespace MmosCourseProject.BLL.Services.DomainConstraintsValidatiotors
{
    public class DomainConstraintsValidationFactory
    {
        /// <summary>
        /// Binds DbEntity type to corresponding IDomainConstraintsValidator
        /// </summary>
        private static Dictionary<Type, Func<object>> _validatorResolver
            //Func<object> потому что, если использовать IDomainConstraintsValidator, то будет конфликт ковариантности - контравариантности
            = new Dictionary<Type, Func<object>>
            {
                { typeof(Channel), () => new ChannelConstraintsValidator() },
                { typeof(ChatMessage), () => new ChatMessageConstraintsValidator() },
                { typeof(Comment), () => new CommentConstraintsValidator() },
                { typeof(Task), () => new TaskConstraintsValidator() },
                { typeof(Team), () => new TeamConstraintsValidator() },
                { typeof(User), () => new UserConstraintsValidator() },
                { typeof(Object), () => throw new ArgumentException("No corresponding validor for this entity")}
            }

        /// <summary>
        /// Returns corresponding validator for Database Entity
        /// </summary>
        /// <typeparam name="DbEntity">Database Entity</typeparam>
        public static IDomainConstraintsValidator<DbEntity> GetValidator<DbEntity>()
        {
            return (IDomainConstraintsValidator<DbEntity>)_validatorResolver[typeof(DbEntity)].Invoke();
        }
    }
}
